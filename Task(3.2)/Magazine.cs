
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Task_3._2_
{
    internal class Magazine : Edition, InterfaceRateAndCopy
    {
        private ArrayList magazineEditors;
        private ArrayList articleArray;
        private Frequency frequency;

        public Magazine(string title
            , DateTime releaseDate
            , int circulation
            , ArrayList magazineEditors
            , ArrayList articleArray
            , Frequency frequency)
            : base(title, releaseDate, circulation)
        {
            this.MagazineEditors = magazineEditors;
            this.ArticleArray = articleArray;
            this.frequency = frequency;
        }
        public Magazine() : base()
        {
            Article article = new Article(new Person("Person1: ", 32), "AticleDefault", 23.4);
            this.ArticleArray = new ArrayList();
            ArticleArray.Add(article);
            Person person = new Person("DefaultPerson", 34);
            this.MagazineEditors = new ArrayList();
            MagazineEditors.Add(person);
            this.frequency = 0;
        }


        public Frequency Frequency { get => frequency; set => frequency = value; }
        public ArrayList MagazineEditors { get => magazineEditors; set => magazineEditors = value; }

        public ArrayList ArticleArray { get => articleArray; set => articleArray = value; }

        public Edition Edition { get; set; }
        public double AverageRate
        {
            get
            {
                return ArticleArray.ToArray().Average(x => (x as Article).Rate);
            }
        }

        // TODO: fix this
        public double Rating
        {
            get
            {
                return 0;
            }
        }

        //public double Rating
        //{
        //    get
        //    {
        //        return this.rate; // ??? 
        //    }
        //}



        public bool this[int i]
        {
            get
            {
                if (i == (int)frequency)
                    return true;
                else
                    return false;
            }
        }

        public void AddArticles(params Article[] articles)
        {
            foreach (Article article in articles)
            {
                ArticleArray.Add(article);
            }
        }

        public void AddEditors(params Person[] persons)
        {
            foreach (Person person in persons)
            {
                magazineEditors.Add(person);
            }

        }


        public override string? ToString()
        {
            string articleNames = "";
            foreach (Article article in this.ArticleArray)
            {
                articleNames += article.ToString() + "\n";
            }
            string editorsNames = "";
            foreach (Person person in this.MagazineEditors)
            {
                editorsNames += person.ToString() + "\n";
            }
            return $"\nToString: Title: {Title} \nDateTime: {ReleaseDate} " +
                $"\nCirculation: {Circulation} " +
                $"\nFrequency: {this.frequency}" +
                $"ArticleArray : {articleNames}"
                + $"EditorsArray: {editorsNames}\n\n";
        }

        public virtual string? ToShortString()
        {
            return "ToShortString: " + base.ToString + $"Frequency: {frequency}, AverageRate: {AverageRate}";
        }

        public override object DeepCopy()
        {
            return new Magazine(Title,
                ReleaseDate,
                Circulation,
                MagazineEditors,
                ArticleArray, Frequency);
        }

        // TODO: Fix this
        //public bool Load(string filemname)
        //{
        //    try
        //    {
        //        string text = File.ReadAllText(filemname);
        //        Magazine? temp = JsonConvert.DeserializeObject<Magazine>(text);
        //        this.Title = temp.Title;
        //        this.ReleaseDate = temp.ReleaseDate;
        //        this.Circulation = temp.Circulation;
        //        this.Frequency = temp.Frequency;

        //        for (int i = 0; i < temp.MagazineEditors.Count; i++)
        //        {
        //            Person editor = temp.MagazineEditors[i] as Person;
        //            this.MagazineEditors.Add(new Person(editor.NameAuthor, editor.AgeAuthor));
        //        }
        //        this.MagazineEditors = temp.MagazineEditors;

        //        for (int i = 0; i < temp.ArticleArray.Count; i++)
        //        {
        //            Article artile = temp.ArticleArray[i] as Article;
        //            Person editor = new Person(artile.Person.NameAuthor, artile.Person.AgeAuthor);
        //            this.ArticleArray.Add(new Article(editor, artile.Name, artile.Rate));
        //        }
        //        this.ArticleArray = temp.ArticleArray;
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        public bool Save(string fullpath)
        {
            try
            {
                string result = JsonConvert.SerializeObject(this);

                using (StreamWriter writer = new StreamWriter(fullpath))
                {
                    writer.WriteLine(result);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }

        public IEnumerable<double> GetArticlesByRating(double rating)
        {
            int index = 0;
            while (index < articleArray.Count)
            {
                Article article = articleArray[index] as Article;
                if (article != null && article.Rating > rating)
                    yield return index;
                index++;
            }

        }
        ///article.Contains// 

        /*
         public IEnumerable<int> GetSingleDigitOddNumbers(bool getCollection)
        {
            if (getCollection == false)
                return new int[0];
            else
                return IteratorMethod();
        }

        private IEnumerable<int> IteratorMethod()
        {
            int index = 0;
            while (index < 10)
            {
                if (index % 2 == 1)
                    yield return index;
                index++;
            }
        }
         */










    }
}



