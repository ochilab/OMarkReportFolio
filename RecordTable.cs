using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace OMarkReportFolio {
    class RecordTable {

        private SortedList idTable;

        private List<string> idList;

        public List<string> IdList {
            get { return idList; }
        }

        private List<string> dayTypeList;
        public List<string> DayTypeList {
            get {
                return dayTypeList; 
            }
            
        }

        public SortedList getScoreList(string id) {

            List<Report> result = new List<Report>();
            if (idTable.ContainsKey(id)) {
                return (SortedList)idTable[id];
            } else {
                return null;
            }
        }

        public Report getReport(string id, string dayType) {

            Report report ;

            SortedList stable = (SortedList)idTable[id];
            if (stable.ContainsKey(dayType)) {
                report = (Report)stable[dayType];

            } else {
                report = null;
            }

            return report;
        }

        public RecordTable(List<Report> reportList) {
            SortedList scoreTable;
            SortedList dayTypeTable = new SortedList();
            idTable = new SortedList();
            foreach (Report repo in reportList) {
                //StuIdがある場合
                if (idTable.ContainsKey(repo.StuId)) {
                    scoreTable = (SortedList)idTable[repo.StuId];
                }

                //StuIdない場合
                else {
                    scoreTable = new SortedList();
                }
                dayTypeTable[repo.Day + repo.Type] = "";

                //列ごと保存
                scoreTable[repo.Day + repo.Type] = repo;
                idTable[repo.StuId] = scoreTable;
            }

            dayTypeList = new List<string>();
            foreach (DictionaryEntry d in dayTypeTable) {
                dayTypeList.Add((string)d.Key);
            }
            idList = new List<string>();
            foreach (DictionaryEntry d in idTable) {
                idList.Add((string)d.Key);

            }
        }

    }
}
