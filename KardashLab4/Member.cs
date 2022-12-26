using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KardashLab4
{
    internal class Member
    {
        public Member()
        {
            MemberInfo = new MemberInfo();
            Theme = "";
            WorkTime = "";
            Performance = "";
            Materials = "";
        }

        public Member(List<string> eventData)
        {
            MemberInfo = new MemberInfo(
                eventData[0] + "",
                eventData[1] + "",
                eventData[2] + ""
                );
            Theme = eventData[3] + "";
            WorkTime = eventData[4] + "";
            Performance = eventData[5] + "";
            Materials = eventData[6] + "";
        }

        public Member(DataGridViewRow row)
        {
            MemberInfo = new MemberInfo(
                row.Cells[0].Value + "",
                row.Cells[1].Value + "",
                row.Cells[2].Value + ""
                );

            Theme = row.Cells[3].Value + "";
            WorkTime = row.Cells[4].Value + "";
            Performance = row.Cells[5].Value + "";
            Materials = row.Cells[6].Value + "";
        }

        public Member(MemberInfo memberInfo, string theme, string workTime, string performance, string materials)
        {
            MemberInfo = memberInfo;
            Theme = theme;
            WorkTime = workTime;
            Performance = performance;
            Materials = materials;
        }

        public MemberInfo MemberInfo { get; set; }
        public string Theme { get; set; }
        public string WorkTime { get; set; }
        public string Performance { get; set; }
        public string Materials { get; set; }
        public string[] GetStringData()
        {
            string[] row = {
                MemberInfo.PIP,
                MemberInfo.Age.ToString(),
                MemberInfo.Role,
                Theme,
                WorkTime,
                Performance,
                Materials
            };

            return row;
        }
    }
}
