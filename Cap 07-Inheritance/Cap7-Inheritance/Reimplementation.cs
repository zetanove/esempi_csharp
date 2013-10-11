﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap7_Inheritance
{
    interface IDocument
    {
        void Print();
        void Print2();

        void ExPrint();
        void ExPrint2();
    }

    class Report: IDocument
    {
        public void Print()
        {
            Console.WriteLine("Report.Print");
        }

        public virtual void Print2()
        {
            Console.WriteLine("Report.Print2");
        }

        void IDocument.ExPrint()
        {
            Console.Write("IDocument.ExPrint ->");
            this.ExPrint();
        }

        protected virtual void ExPrint()
        {
            Console.WriteLine("Report.ExPrint");
        }

        void IDocument.ExPrint2()
        {
            Console.WriteLine("IDocument.ExPrint2");
        }
    }

    class SubReport : Report
    {
        public new void Print()
        {
            Console.WriteLine("SubReport.Print");
        }

        public override void Print2()
        {
            Console.WriteLine("SubReport.Print");
        }

        protected override void ExPrint()
        {
            Console.WriteLine("SubReport.ExPrint");
        }
    }

    class SpecialSubReport : Report, IDocument
    {
        public void ExPrint2()
        {
            Console.WriteLine("SpecialSubReport.ExPrint2");
        }

    }
}

