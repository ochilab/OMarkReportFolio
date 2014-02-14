namespace OMarkReportFolio {
    class Report {

        //以下は科目IDを構成する
        private string year; //年度

        public string Year {
            get { return year; }
            set { year = value; }
        }
        private string term; //学期

        public string Term {
            get { return term; }
            set { term = value; }
        }
        private string wday; //曜日

        public string Wday {
            get { return wday; }
            set { wday = value; }
        }
        private string period; //限目

        public string Period {
            get { return period; }
            set { period = value; }
        }
        private string subName; //科目名

        public string SubName {
            get { return subName; }
            set { subName = value; }
        }


        private string day; //講義日時

        public string Day {
            get { return day; }
            set { day = value; }
        }



        //以下は、レポートIDを構成する

        private string fileName; //スキャンしたファイル名

        public string FileName {
            get { return fileName; }
            set { fileName = value; }
        }


        private string scanDay;

        public string ScanDay {      //スキャンした日時
            get { return scanDay; }
            set { scanDay = value; }
        }

        private string page;  //何ページ目か？

        public string Page {
            get { return page; }
            set { page = value; }
        }



        private string stuId; //学籍番号

        public string StuId {
            get { return stuId; }
            set { stuId = value; }
        }
        private string type; //レポートのタイプ

        public string Type {
            get { return type; }
            set { type = value; }
        }


        private string point;//得点

        public string Point {
            get { return point; }
            set { point = value; }
        }

        private bool scanFlag;

        public bool ScanFlag {
            get { return scanFlag; }
            set { scanFlag = value; }
        }

        private string number;//枚数

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        // 以下はコンストラクタ ///////////


        public Report() {
        }

        public Report(string year,string term, string wday, string period ,string subName) {

            this.year = year;//年度
            this.term = term;//学期
            this.wday = wday;//曜日
            this.period = period;//時間目
            this.subName = subName;//科目名

       
        }




    }
}
