using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class Mediator
    {
        private Dictionary<string, List<IWidget>> dependency = new Dictionary<string, List<IWidget>>();
        public Location location { get; set; }
        public Timezone timeZone { get; set; }
        public PrayerTimeSettings prayerTimeSettings { get; set; }
        public CurrentTime currentTime { get; set; }
        public WaqtTimesTable waqtTimesTable { get; set; }
        public PrayerTimesTable prayerTimesTable { get; set; }
        public CurrentWaqt currentWaqt { get; set; }
        public NextPrayer nextPrayer { get; set; }

        public Mediator() { }

        public void AddDependency(Location _location, 
                        Timezone _timeZone,
                        PrayerTimeSettings _prayerTimeSettings,
                        CurrentTime _currentTime,
                        WaqtTimesTable _waqtTimesTable,
                        PrayerTimesTable _prayerTimesTable,
                        CurrentWaqt _currentWaqt,
                        NextPrayer _nextPrayer
                        ) 
        {
            location = _location;
            timeZone = _timeZone;
            prayerTimeSettings = _prayerTimeSettings;
            currentTime = _currentTime;
            waqtTimesTable = _waqtTimesTable;
            prayerTimesTable = _prayerTimesTable;
            currentWaqt = _currentWaqt;
            nextPrayer = _nextPrayer;
            Register();
        }

        public void Register()
        {
            dependency.Add(location.id, new List<IWidget> { waqtTimesTable});

            dependency.Add(timeZone.id, new List<IWidget> { currentTime, waqtTimesTable});

            dependency.Add(prayerTimeSettings.id, new List<IWidget> { prayerTimesTable});

            dependency.Add(currentTime.id, new List<IWidget> { currentWaqt, nextPrayer });

            dependency.Add(waqtTimesTable.id, new List<IWidget> { currentWaqt });

            dependency.Add(prayerTimesTable.id, new List<IWidget> { nextPrayer });

            dependency.Add(currentWaqt.id, new List<IWidget> { });

            dependency.Add(nextPrayer.id, new List<IWidget> { });
        }

        public void Notify(string id)
        {
            Update(id);
        }

        public void Update(string id)
        {
            foreach (var widget in dependency[id])
            {
                widget.Update();
            }
        }

    }
}
