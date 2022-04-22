using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._2_
{
    internal class Edition
    {
        private string title;
        private DateTime releaseDate;
        private int circulation;

        public string Title { get => title; set => title = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public int Circulation
        {
            get { return circulation; }
            set {
                if (value < 0) throw new Exception("your value < 0");
                circulation = value;
            }
        }

        public Edition(string title, DateTime releaseDate, int circulation)
        {
            this.Title = title;
            this.ReleaseDate = releaseDate;
            this.Circulation = circulation;
        }
        public Edition()
        {
            this.Title = "Times";
            this.ReleaseDate = new DateTime(2011,6,10);
            this.Circulation = 10;
        }

        //public virtual DeepCopy()
        //{
        //    return 
        //}

        public virtual object DeepCopy()
        {
            return new Edition(Title, ReleaseDate, Circulation);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;

            Edition edition = obj as Edition;
            if (edition != null &&
                edition.title == this.title
                && edition.releaseDate == this.releaseDate
                && edition.circulation == this.circulation)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return title.GetHashCode() ^ 
                releaseDate.GetHashCode() ^ 
                circulation.GetHashCode();
        }

        public override string? ToString()
        {
            return $"\nToString: Title: {title} \nDateTime: {releaseDate} " +
                $"\nCirculation: {circulation}";
        }



    }
}
