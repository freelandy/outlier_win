using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using edu.stanford.nlp.pipeline;
using java.io;
using java.util;
using edu.stanford.nlp.util;
using edu.stanford.nlp.ling;
using static edu.stanford.nlp.ling.CoreAnnotations;

namespace Outlier
{
    // 问题1：序数词标记不出来，统一标记为形容词
    // 问题2：比较级和最高级能标记，但不能做词形还原
    // 问题3：大小写暂时未处理，区分大小写
    public class Processor
    {
    //    private readonly string[] dllNames = new string[] {
    //    "IKVM.AWT.WinForms.dll" ,
    //    "IKVM.OpenJDK.Beans.dll",
    //    "IKVM.OpenJDK.Charsets.dll",
    //    "IKVM.OpenJDK.Corba.dll",
    //    "IKVM.OpenJDK.Core.dll",
    //    "IKVM.OpenJDK.Jdbc.dll",
    //    "IKVM.OpenJDK.Management.dll",
    //    "IKVM.OpenJDK.Media.dll",
    //    "IKVM.OpenJDK.Misc.dll",
    //    "IKVM.OpenJDK.Naming.dll",
    //    "IKVM.OpenJDK.Remoting.dll",
    //    "IKVM.OpenJDK.Security.dll",
    //    "IKVM.OpenJDK.SwingAWT.dll",
    //    "IKVM.OpenJDK.Text.dll",
    //    "IKVM.OpenJDK.Util.dll",
    //    "IKVM.OpenJDK.XML.API.dll",
    //    "IKVM.OpenJDK.XML.Bind.dll",
    //    "IKVM.OpenJDK.XML.Parse.dll",
    //    "IKVM.Runtime.dll",
    //    "IKVM.Runtime.JNI.dll",
    //    "ejml-0.23.dll",
    //    "javax.json.dll",
    //    "doda-time.dll",
    //    "jollyday.dll",
    //    "xom.dll",
    //    "stanford-corenlp-3.4.dll"};


        //private readonly string jarRoot = "models-20170609";

        private readonly string stopwordsDictionaryPath = "dic\\stopwords";
        private readonly string dictionaryRoot = "dic";
        private readonly List<string> Punctuations = new List<string>() {",", ";",".","!","?","\"","'",":","/","\\","<",">","%","$","@","(",")","-","+","=","_","*","&","^","#","~","`","|","{","}","[","]","''","``" };
        private readonly List<string> Abbreviations = new List<string>() {"'d", "n'd", "n't", "'ll", "'re", "'ve", "'s", "ain't" };
        

        private Properties props = new Properties();
        private StanfordCoreNLP pipeline;
        private HashSet<string> userDictionary = new HashSet<string>();
        private List<string> stopwords = new List<string>();

        public List<string> UserDictionaryNames { set; get; } = new List<string>();

        // 标记配置
        public bool StopwordMarking { set; get; } = false; // I, is, to, the, ...
        public bool PunctuationMarking { set; get; } = false; // ,, ., ?, ...
        public bool CardinalNumberMarking { set; get; } = false; // 120, 11,000, twenty-four
        public bool ComparativeMarking { set; get; } = true; // shorter
        public bool SuperlativeMarking { set; get; } = true; // shortest
        public bool AbbreviationMarking { set; get; } = false; // I'd, don't, you're, ...
        


        protected void InitializeProcessor()
        {
            this.props.setProperty("annotators", "tokenize, ssplit, pos, lemma"); // lemma needs ssplit and pos, pos needs ssplit
            this.pipeline = new StanfordCoreNLP(this.props);

            this.InitializeStopwords();
        }


        public void InitializeUserDictionary()
        {
            this.userDictionary.Clear();

            // read in words
            string text = string.Empty;
            
            foreach(string s in this.UserDictionaryNames)
            {
                string fileName = this.dictionaryRoot + "\\" + s + ".txt";

                if(System.IO.File.Exists(fileName))
                {
                    text += System.IO.File.ReadAllText(fileName, Encoding.UTF8);
                }
            }

            // segment into words
            Properties ps = new Properties();
            ps.setProperty("annotators", "tokenize, ssplit");
            StanfordCoreNLP pipe = new StanfordCoreNLP(ps);

            Annotation annotation = new Annotation(text); 
            pipe.annotate(annotation);

            ArrayList sentences = (ArrayList)annotation.get(new SentencesAnnotation().getClass());

            foreach(CoreMap sentence in sentences)
            {
                ArrayList tokens = (ArrayList)sentence.get(new TokensAnnotation().getClass());

                foreach(CoreLabel token in tokens)
                {
                    this.userDictionary.Add(token.word().ToLower());
                }
            }
        }

        private void InitializeStopwords()
        {
            string text = string.Empty;
            if(System.IO.File.Exists(this.stopwordsDictionaryPath))
            {
                text = System.IO.File.ReadAllText(this.stopwordsDictionaryPath, Encoding.UTF8);
            }

            // segment into words
            this.stopwords = text.Split(Environment.NewLine.ToCharArray()).ToList<string>();

        }

        public List<string> GetDictionaryNames()
        {
            DirectoryInfo dir = new DirectoryInfo(this.dictionaryRoot);
            FileInfo[] dics = dir.GetFiles("*.txt");

            List<string> dicList = new List<string>();
            foreach(FileInfo f in dics)
            {
                dicList.Add(f.Name.Substring(0, f.Name.Length - 4));
            }

            return dicList;
        }


        public Processor()
        {
            this.InitializeProcessor();
        }


        public Processor(bool stopwordMarking, bool punctuationMarking, bool cardinalNumberMarking, bool comparativeMarking, bool superlativeMarking)
        {
            this.InitializeProcessor();

            this.StopwordMarking = stopwordMarking;
            this.PunctuationMarking = punctuationMarking;
            this.CardinalNumberMarking = cardinalNumberMarking;
            this.ComparativeMarking = comparativeMarking;
            this.SuperlativeMarking = superlativeMarking;
        }



        public HashSet<string> Process(string text)
        {
            List<Token> processedTokens = new List<Token>();

            Annotation annotation = new Annotation(text);
            this.pipeline.annotate(annotation);

            ArrayList sentences = (ArrayList)annotation.get(new SentencesAnnotation().getClass());

            foreach (CoreMap sentence in sentences)
            {
                ArrayList tokens = (ArrayList)sentence.get(new TokensAnnotation().getClass());

                foreach (CoreLabel token in tokens)
                {
                    Token t = new Token();
                    t.Word = token.word();
                    t.Lemma = token.lemma();
                    t.Pos = token.getString(new CoreAnnotations.PartOfSpeechAnnotation().getClass());
                    t.IsInDictionary = this.userDictionary.Contains(token.lemma().ToLower());
                    t.IsStopword = this.stopwords.Contains(token.word().ToLower());
                    t.IsPunctuation = this.Punctuations.Contains(token.word());
                    t.IsAbbreviation = this.Abbreviations.Contains(token.word());
                    t.IsCardinalNumber = (t.Pos == "CD");
                    t.IsComparative = (t.Pos == "JJR");
                    t.IsSuperlative = (t.Pos == "JJS");
   
                    processedTokens.Add(t);
                }
            }

            processedTokens = this.ProcessAbbreviations(processedTokens);


            HashSet<string> returnedWords = new HashSet<string>();
            foreach(Token t in processedTokens)
            {
                if(this.GetMarkingFlag(t))
                {
                    returnedWords.Add(t.Word);
                }
            }

            return returnedWords;
        }


        
        private bool GetMarkingFlag(Token t)
        {
            bool returnFlag = true;
            if (t.IsStopword && !this.StopwordMarking)
            {
                returnFlag = false;
            }
            if (t.IsPunctuation && !this.PunctuationMarking)
            {
                returnFlag = false;
            }
            if (t.IsCardinalNumber && !this.CardinalNumberMarking)
            {
                returnFlag = false;
            }
            if (t.IsComparative && !this.ComparativeMarking)
            {
                returnFlag = false;
            }
            if (t.IsSuperlative && !this.SuperlativeMarking)
            {
                returnFlag = false;
            }

            if(t.IsInDictionary)
            {
                returnFlag = false;
            }

            return returnFlag;
        }


        public List<Token> ProcessAbbreviations(List<Token> tokens)
        {
            // merge abbreviations ('d, n't, 'll, 're...) with its previous token
            List<Token> newTokens = new List<Token>();
            
            for(int i=0;i<tokens.Count;i++)
            {
                Token token = tokens[i];
                if(this.Abbreviations.Contains(token.Word))
                {
                    if(i>0)
                    {
                        Token t = tokens[i - 1];
                        t.Word = t.Word + tokens[i].Word;
                        newTokens.Add(t);
                    }
                }
                else if(i == tokens.Count-1 || !tokens[i+1].IsAbbreviation)
                {
                    newTokens.Add(tokens[i]);
                }
            }

            return newTokens;
        }
    }
}
