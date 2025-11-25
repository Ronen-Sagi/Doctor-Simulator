# Doctor Simulator 🩺  
סימולטור רופא למחשב

ב-Doctor Simulator אתה משחק רופא צעיר בבית חולים.  
המטרה שלך היא לאבחן ולטפל בחולים, לנהל ציוד ומשמרות, ולקבל החלטות נכונות בזמן לחץ.  
המשחק משלב למידה חווייתית עם חוויה מהנה של הצלת חיים.

🎮 **פלטפורמה:** מחשב  
👤 **שחקן יחיד**  
⚕️ **סוג המשחק:** סימולציה / ניהול זמן  

יוצרים: שגיא חסיד ורונן צ'רשניה

[formal elements](https://github.com/Ronen-Sagi/Doctor-Simulator/blob/main/formal%20elements.md)

[itch.io](https://rs-co.itch.io/doctor-simulator)


    +---------------------+
    |   ResourceManager   |
    +---------------------+
    | - money : int       |
    | - OnMoneyChanged    |
    +---------------------+
    | + Money : int       |
    | + AddMoney(int)     |
    | + SpendMoney(int)  |
    +---------------------+

           ▲
           |
    +---------------------------+
    |    MoneyUI               |
    +---------------------------+
    | - moneyText : TMP_Text   |
    +---------------------------+
    | + Start()                |
    | - UpdateUI(int)          |
    | + OnDestroy()            |
    +---------------------------+


    +---------------------------+
    |        Building           |
    +---------------------------+
    | - cost : int             |
    | - level : int            |
    | - nameTag : TMP          |
    | - levelTag : TMP         |
    +---------------------------+
    | + Cost : int             |
    | + ActivateBuilding()     |
    | - LevelUp()              |
    | + Start()                |
    +---------------------------+


                 +------------------------------+
                 |  BuildingButtonsScript       |
                 +------------------------------+
                 | - cityHall : GameObject      |
                 | - school : GameObject        |
                 | - hospital : GameObject      |
                 | - b : Building               |
                 +------------------------------+
                 | + BuildCityHall()            |
                 | + BuildSchool()              |
                 | + BuildHospital()            |
                 | + Build()                    |
                 +------------------------------+


---


