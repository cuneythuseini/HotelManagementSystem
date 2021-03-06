# Hotel Management System - проект по Визуелно програмирање

## Опис на апликацијата
Целта на проектот е складирање и управување со информациите на муштериите во хотелот во датабаза. Бидејќи целна публика се луѓето кои работат во делот за прием во хотелот, во проектот има и дополнителни карактеристики како што е слушање на радио и читање весник.

## Упатство за користењe
Ајде да го испитаме административниот панел што ни овозможува да се најавуваме на програмата. Сликата што ја гледате подолу е административниот панел за најавување на програмата и корисничкото име е "администратор" и лозинката е "1234". Ако корисничкото име и лозинката се правилно внесено, програмата ќе се логира во системот, во спротивно програмата ќе даде грешка и нема да се логира во системот.

![Admin Picture](https://github.com/cuneythuseini/HotelManagementSystem/blob/master/img/admin.png)

### Почетна страница
Кога правилно се најавуваме во системот, одиме на главната страница. Проектот се состои од вкупно девет делови. Да ги испитаме овие девет делови детално.
![Home Page](https://github.com/cuneythuseini/HotelManagementSystem/blob/master/img/HomePage.png)

### Нов Муштерија
За да додадете нов муштерија, мора да кликнете на копчето „нов муштерија“ .Откако ќе дојдете во новиот формулар за муштерија, треба да ги внесете потребните информации за клиентот (не може да оставите празен простор, програмата ќе даде порака за предупредување доколку оставите празно место).
За да се зачува информациите во датабаза, мора да кликнете на копчето за зачувување и да ја потврдите дојдовната порака.Ако не ја одобрите дојдовната порака, информациите нема да бидат зачувани во датабаза.

![New Customer](https://github.com/cuneythuseini/HotelManagementSystem/blob/master/img/NewCustomer1.png)
![New Customer](https://github.com/cuneythuseini/HotelManagementSystem/blob/master/img/NewCustomer2.png)
![New Customer](https://github.com/cuneythuseini/HotelManagementSystem/blob/master/img/Screenshot_3.png)

### Соби
Можете да отидете во формуларот за соби со кликнување на копчето „Соби“. Можете да ги видите зафатените и празни простории во образецот Соби. Црвените копчиња ги претставуваат пополнетите соби и зелените копчиња ги претставуваат празните соби.

![Rooms](https://github.com/cuneythuseini/HotelManagementSystem/blob/master/img/Rooms.png)

### Муштерии
Вкупно има пет копчиња во панелот Муштерии. Функциите на копчињата се соодветно: прегледување записи во базата на податоци, бришење записи, уредување записи, пребарување записи и расчистување на текстуални полиња. Сега да ги испитаме функциите на копчињата, соодветно.

#### 1) Покажи
![Show](https://github.com/cuneythuseini/HotelManagementSystem/blob/master/img/Pokazi.png)

#### 2) Избриши
![Delete](https://github.com/cuneythuseini/HotelManagementSystem/blob/master/img/Izbrisi1-vert.jpg)

#### 3) Удредувај
![Update](https://github.com/cuneythuseini/HotelManagementSystem/blob/master/img/Udreduvaj_nov-vert.jpg)

#### 4) Барај
![Search](https://github.com/cuneythuseini/HotelManagementSystem/blob/master/img/Baraj.png)

#### 5) Чисти
![Clear](https://github.com/cuneythuseini/HotelManagementSystem/blob/master/img/cist1-vert.jpg)

### Слушајте Радио
За да слушате радио, треба да кликнете на копчето за слушање радио.Вкупно има 4 канали во форма на радио, можете да кликнете на каналот што го сакате и да го слушате.

![Radio](https://github.com/cuneythuseini/HotelManagementSystem/blob/master/img/Radio1.png)

### Прочитајте Весник
За да прочитате весник, треба да кликнете на копчето за читање весник.Вкупно има 5 весници во образецот за читање весник, можете да кликнете на посакуваниот весник и да го прочитате.
![NewsPaper](https://github.com/cuneythuseini/HotelManagementSystem/blob/master/img/Vesnik.png)

### Пораки од клиенти

#### 1) Зачувај 
За да се зачува информациите во датабаза, мора да кликнете на копчето за зачувување и да ја потврдите дојдовната порака.Ако не ја одобрите дојдовната порака, информациите нема да бидат зачувани во датабаза.

![Save](https://github.com/cuneythuseini/HotelManagementSystem/blob/master/img/ZacuvajPorakiOdKlienti.png)

#### 2) Избриши
Кликнете двапати на бројот на мушјтеријата што сакате да го избришете во колоната „No“, а потоа кликнете на копчето за бришење и потврдете ја дојдовната порака.

![Delete](https://github.com/cuneythuseini/HotelManagementSystem/blob/master/img/IzbrisiPorakiOdKlienti.png)

#### 3) Удредувај
Кликнете двапати на бројот на клиент што сакате да го ажурирате во колоната „No“ и променете ги информациите внесени во полето за текст и кликнете на копчето „ажурирање“.

![Update](https://github.com/cuneythuseini/HotelManagementSystem/blob/master/img/UdreduvajPorakiOdKlienti.png)

#### 4) Чисти
Кликнете на копчето за чистење за да ги исчистите полињата за текст.

### За Нас
Кракот порака за нас.

### Излез
Копче за да излезете од апликацијата.

## Опис на формата FrmCustomers
Бидејќи формата муштерии е најважниот дел од проектот,да ги испитаме кодовите на образецот муштерии.

Бидејќи базата на податоци се користи во проектот, додадената база на податоци мора да работи на секој компјутер. Затоа, кога креираме објект од класата "OleDbConnection", треба да ја користите командата "Application.StartupPath".



`OleDbConnection oleDbConnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\CustomerInfos.mdb");`

Во методата showInfos() селектираме сите инфорамции во access датабаза.Додека имаме инфорамции во соодветната колона со користење listViweItem читаме едно по едно информацијата  и пиркажиуваме во ListView за да гледа корисникот.Кога ќе заврши while циклусот мора да затвориме датабазата за да не се појави грешка понатаму.


    private void showInfos()
        {
            listView1.Items.Clear();
            oleDbConnection.Open();

            OleDbCommand oleDbCommand = new OleDbCommand();
            oleDbCommand.Connection = oleDbConnection;
            oleDbCommand.CommandText = "select * from Informations";

            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();

            while (oleDbDataReader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = oleDbDataReader["NoCustomer"].ToString();
                listViewItem.SubItems.Add(oleDbDataReader["Name"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["LastName"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["Gender"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["PhoneNumber"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["IDNumber"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["NumberOfRooms"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["EMail"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["Price"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["EntryDate"].ToString());
                listViewItem.SubItems.Add(oleDbDataReader["ReleaseDate"].ToString());

                listView1.Items.Add(listViewItem);
            }
            oleDbConnection.Close();
        }
        
Метод за бришење муштерија;Соодветно отвориме датабазата проверуваме дали е полн доколку е полн  односно дали е муштеријата точно селектриано ако е точно селектирана тогаш бришеме муштерија според ID, т.е **noOfCustomer**.(Со корисење команди за датабази).

     private void btnDelete_Click(object sender, EventArgs e)
        {
            oleDbConnection.Open();

            if (isFill())
            {
                OleDbCommand oleDbCommand = new OleDbCommand("delete from Informations where NoCustomer=(" + noOfCustomer + ")", oleDbConnection);

                if (MessageBox.Show("Дали сакате да избришете муштеријата", "Избриши", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    oleDbCommand.ExecuteNonQuery();
                    clearAllAreas();
                }
            }
            else
            {
                MessageBox.Show("Селектриајте Муштерија за да избришете инофрмациите", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            oleDbConnection.Close();

            showInfos();

        }

