using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nuCypherUI.Utils
{
    public class ApiDataAdapter
    {
        public object GetDashboardData()
        {
            // ToDo: need rest(?) client
            // and get data from API

            var json = @"{
                cols: [
                    { id: 'years', label: 'Time (years)', type: 'string' },
                    { id: 'percentCompensation', label: 'Compensation', type: 'number' },
                ],
                rows: [
                    { c: [{ v: '0' }, { v: 0, f: '0%' }] },
                    { c: [{ v: '1' }, { v: 8, f: '8%' }] },
                    { c: [{ v: '2' }, { v: 15, f: '15%' }] },
                    { c: [{ v: '3' }, { v: 21, f: '21%' }] },
                    { c: [{ v: '4' }, { v: 26, f: '26%' }] },
                    { c: [{ v: '5' }, { v: 30, f: '30%' }] }
                ]}";

            return JObject.Parse(json);
        }

        public object GetBalanceData()
        {
            var json = @"{
                cols: [
                    { id: 'weeks', label: 'Time (weeks)', type: 'string' },
                    { id: 'balanceAmount', label: 'Balance amount', type: 'number' }
                ],
                rows: [
                    { c: [{ v: '4 weeks ago' }, { v: 20 }] },
                    { c: [{ v: '3 weeks ago' }, { v: 15 }] },
                    { c: [{ v: '2 weeks ago' }, { v: 29 }] },
                    { c: [{ v: 'last week' }, { v: 26 }] },
                    { c: [{ v: 'now' }, { v: 32 }] }
                ]}";

            return JObject.Parse(json);
        }
    }
}
