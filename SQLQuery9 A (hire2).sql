create database Hire2
use Hire2
create table vechicle_type
(vt_id int identity,
vt_name varchar(25),
constraint vechicle_type_id_pk primary key(vt_id));

insert into vechicle_type(vt_name)values
('car');
insert into vechicle_type values
('van'),
('bus'),
('bike'),
('lorry');
select * from vechicle_type;
select * from vechicle;
select * from Rates
select * from driver
select * from Rent


 insert into customer ( customer_name , customer_address, customer_teleno ) 
   values ('hamshan' , 'kirankulam' , '0751110137');
   insert into customer values ('kuga' , 'Batticaloa' , '0756585629');
   insert into customer values ('vasu' , 'kirankulam' , '0758978963');
  insert into customer values  ('najilan' , 'aarayampathy' , '0758585125');
    insert into customer values  ('shangeerth' , 'kurukkalmadam' , '0752725351');

DELETE FROM Customer WHERE customer_name='hamshan';






	select * from Tour_Type

	 select Rates.perday , perday * 7 as perweek , perday * 30 as permonth , vechicle_type.vt_name from  Rates join vechicle_type on Rates.vt_id = vechicle_type.vt_id 


select Rent.rent_id, vechicle_type.vt_name,driver.driver_name from Rent 
join driver on driver.driver_id = Rent.driver_id
join vechicle on vechicle.vechicle_id = Rent.vechicle_id
join vechicle_type on vechicle_type.vt_id = vechicle.vt_id_fk
select *from rent

select * from vechicle_type
select * from vechicle
select * from hire_payment

insert into driver (driver_Name,driver_address,driver_teleno,driver_licence_no,driver_rate,driver_over_night_charge,driver_waiting_charge) 
values ('kamal' , 'kirankulam' , '074565025' , 'asd456' , '50002','8900','20000')
select * from driver


 insert into driver (driver_Name,driver_address,driver_teleno,driver_licence_no,driver_rate,
 driver_over_night_charge,driver_waiting_charge) values ('karan' , 'batticaloa' , '0758996456' , '7852' , '421')

select * from driver

select * from customer

select vt_id as id ,vt_name as name from vechicle_type 

 select rates. Rate_id ,  perday , no_of_days ,perday * no_of_days as amount,
  vechicle.vechicle_no from rates join vechicle on rates.vt_id = vechicle.vechicle_id 

  ALTER TABLE persons
ADD full_name AS (first_name + ' ' + last_name);


Sum(tbl1.fld1 + tbl1.fld2) AS [Total]




 insert into driver (driver_Name,driver_address,driver_teleno,
 driver_licence_no,driver_rate,driver_overNightRate,driver_waitingCharge)
  values ('shanjeef' , 'kirankulam' , '0756508688' , 'B4629123' , '2000','350', '500')


   insert into driver (driver_Name,driver_address,driver_teleno,driver_licence_no,driver_rate,driver_over_night_charge,driver_waiting_charge) values ('shanjeef' , 'kirankulam' , '0756508688' , 'B4629123' , '2000','350', '500')









  insert into Rates(perday) values ('2000')

  select Rates.rate_id,perday,no_of_days,amount ,vechicle_type.vt_name as vt_name from Rates
  join vechicle_type on vechicle_type .vt_id = rates.vt_id 

  insert into rates ( perday,no_of_days,sum perday + no_of_days as amount ,vt_name ) 


Sum rates.perday + rates.no_of_days AS [Total]


   insert into rates (perDay,no_of_days,amount,vt_name) values ('1', '500' , '7')

    insert into Rates ( perday , vechicle_type.vt_id, no_of_days , amount as ( perdays * no_of_days)) values ('5000','2','2')

	insert into rates  (perday ,vt_id ,no_of_days, select SUM (perday + no_of_days) as amount from rates values ('200' , '2', '5'));


  select * from Rates


  SELECT  SUM (perday + no_of_days) as amount FROM rates;

  insert into rates (perday,vt_id,no_of_days,amount) values ( '3000','2','5','2000'  )


select * from vechicle_type



SELECT rates,(perday + no_of_days) as amount FROM Hire2

select









  select Rent.rent_id, vechicle_type.vt_name,driver.driver_name from Rent 
join driver on driver.driver_id = Rent.driver_id
join vechicle on vechicle.vechicle_id = Rent.vechicle_id
join vechicle_type on vechicle_type.vt_id = vechicle.vt_id_fk








  select * from Rates

  select Rent.rent_id, vechicle_type.vt_name,driver.driver_name from Rent 
join driver on driver.driver_id = Rent.driver_id
join vechicle on vechicle.vechicle_id = Rent.vechicle_id
join vechicle_type on vechicle_type.vt_id = vechicle.vt_id_fk
select * from vechicle_type















create table vechicle
(vechicle_id int identity,
vechicle_no varchar(6),
vt_id int,
constraint vechicle_id_pk primary key(vechicle_id),
constraint vt_id_fk foreign key(vt_id) references vechicle_type(vt_id));
sp_rename 'vechicle.vt_id','vt_id_fk','COLUMN';
alter table vechicle add campany_id int;
alter table vechicle add constraint campany_id_fk foreign key(campany_id) references campany(campany_id);
 select * from vechicle;


 select vechicle. vechicle_id as ID ,vechicle_no as Number,vechicle_type.vt_name 
 from vechicle join vechicle_type on vechicle.vt_id = vechicle_type.vt_id

 select Rates.perday , perweek , permonth , vechicle_type.vt_name from  Rates 
 join vechicle_type on Rates.vt_id = vechicle_type.vt_id

 select Rates.perday , perday * 7 as perweek , perday * 30 as permonth , vechicle_type.vt_name from  Rates 
 join vechicle_type on Rates.vt_id = vechicle_type.vt_id

 insert into Rates (vt_id ,perday) values ( '1','2000')


 select * from vechicle_type




 insert into vechicle ( vechicle_no , vt_id) values ('ABC 9028','1')






 select 

 select vechicle. vechicle_id as ID ,vechicle_no as Number,
 vechicle_type.vt_name from vechicle join vechicle_type on 
 vechicle.vechicle_id_fk = vechicle_type.vt_id



alter table vechicle alter column vechicle_no varchar(10);








  select rent_payment.rp_id , rent.rent_id , rent_payment.rent_charge ,
   rent_payment.rp_date, rent_payment.rp_base_charge from  rent_payment 
   join rent on rent.rent_id = rent_payment.rent_id 


------------------------------------------------------------------------------------


create table Rates
(Rate_id int identity,
 perday float,
 perweek float,
 permonth float,
 vt_id int,
 constraint Rate_id_pk primary key(Rate_id),
 constraint vehicle_Type_fk foreign key(vt_id) references vechicle_type(vt_id));
 alter table rates add no_of_days int;

 alter table rates add constraint no_of_days foreign key( no_of_days) references hire(no_of_days);

 select Rates.perday , Rates.perweek , Rates.permonth ,vechicle_type.vt_id from vechicle_type 
 join Rates.vt_id = vechicle_Type.vt_id


select * from hire

 SELECT * FROM Rates;

 SELECT  SUM (perday + no_of_days) as amount FROM rates;
SELECT rates,(perday *) as amount FROM Hire2

select Rates.perday,perweek,permonth,vechicle_type.vt_name from vechicle_type
join vechicle_type on Rates.vt_id = vechicle_type.vt_id


select rates. Rate_id ,  perday , perweek,permonth,vehicle_type.vt_name from vechicle_type 
join vehicle_type.vt_id = rates.vt_id



 vechicle.vechicle_no from rates join vechicle on rates.vt_id = vechicle.vechicle_id 


 select rates. Rate_id ,  perday , perday * 7  as permonth , 
 vechicle.vechicle_no from rates join vechicle on rates.vt_id = vechicle.vechicle_id 

  ----------------------------------------------------------------------------------------------------

  create table Hire_OtherCharge
 (HOC_id int identity,
 HOC_name varchar(20),
 HOC_AmountPerKM float (10),
 HOC_AmountPerHour float (10),
 constraint HOC_id_pk primary key(HOC_id));

 insert into Hire_OtherCharge ( HOC_Name, HOC_AmountPerKM, HOC_AmountPerHour ) 
 values ( 'short', ' 500 ', '2500' ) 



 select * from Hire_OtherCharge

 ----------------------------------------------------------------

 create table hire
 (hire_id int identity,
 HP_id int,
 vehicle_id int ,
 Tour_Type_id int,
 HOC_id int,
 Driver_id int,
 Hire_NoOfDays int,
 Hire_StartDate datetime,
  Hire_EndDate datetime,
 constraint hire_id_pk primary key(hire_id),
 constraint HP_id_fk foreign key(HP_id) references Hire_Package(HP_id),
 constraint vechi_id_fk foreign key(vehicle_id) references vechicle(vechicle_id),
  constraint Tour_Type_id_fk foreign key(Tour_Type_id) references Tour_Type(Tour_Type_id),
    constraint HOC_id_fk foreign key(HOC_id) references Hire_OtherCharge(HOC_id),
 constraint driver_fk foreign key(driver_id) references driver(driver_id));



 select hire.hire_id  ,Tour_Type.Tour_Type_id , Hire_Package.HP_id ,Hire_OtherCharge.HOC_id,driver.driver_id, 
 hire.Hire_NoOfDays,hire.Hire_StartDate,hire.Hire_EndDate from Tour_Type join hire on
 Tour_Type.Tour_Type_id = hire.Tour_Type_id
 join Hire_Package on Hire_Package.HP_id = hire.HP_id 
 join Hire_OtherCharge on hire.HOC_id = Hire_OtherCharge.HOC_id
 join driver on driver.driver_id = hire.Driver_id
 




 select hire.hire_id  ,Tour_Type.Tour_Type_id , Hire_Package.HP_id ,Hire_OtherCharge.HOC_id,driver.driver_id, hire.Hire_NoOfDays,hire.Hire_StartDate,hire.Hire_EndDate from Tour_Type join hire on Tour_Type.Tour_Type_id = hire.Tour_Type_id join Hire_Package on Hire_Package.HP_id = hire.HP_id join Hire_OtherCharge on hire.HOC_id = Hire_OtherCharge.HOC_id join driver on driver.driver_id = hire.Driver_id
 

   insert into hire ( hp_id  , vehicle_id ,Tour_Type_id,HOC_id, driver_id , Hire_StartDate , Hire_EndDate ,Hire_NoOfDays  ) 
   values ( '4' , '2' ,'2','1', '3' , '2022-10-26' , '2022-11-12' , '15' ) 



   select hire.hire_id  , vechicle.vt_id ,Tour_Type.Tour_Type_Name , Hire_Package.HP_id ,Hire_OtherCharge.HOC_id,driver.driver_Name, 
   hire.Hire_NoOfDays,hire.Hire_StartDate,hire.Hire_EndDate from Tour_Type join hire 
   on Tour_Type.Tour_Type_id = hire.Tour_Type_id join Hire_Package on Hire_Package.HP_id = hire.HP_id 
   join Hire_OtherCharge on hire.HOC_id = Hire_OtherCharge.HOC_id join driver on driver.driver_id = hire.Driver_id 
   join vechicle on vechicle.vechicle_id = hire.vehicle_id



     insert into hire ( hp_id  , vehicle_id ,Tour_Type_id,HOC_id, driver_id ,
	  Hire_StartDate , Hire_EndDate ,Hire_NoOfDays  ) values 
	  ( '4' , '6' , '1' , '2022-10-25' , '2022-10-26' , '2' ) 


   select * from Tour_Type











 select * from Tour_Type
  select * from Hire


 ---------------------------------------------------------------------------

  create table Hire_Package
 (HP_id int identity,
 HP_Name varchar(35),
 HP_Amount float (10),
 HP_MinKM float (10),
 HP_MixKM float (8),
 HP_MixHour float(8),
 constraint HP_pk primary key(HP_id));


 alter table Hire_Package alter column HP_MinKM varchar(10);
alter table Hire_Package alter column HP_MixKM varchar(10);
alter table Hire_Package alter column HP_MixHour varchar(10);
 insert into hire_package ( HP_Name, HP_Amount, HP_MinKM, HP_MixKM , HP_MixHour )
  values ( 'airport drop And pickup', '75000' , '250KM' , '350KM' , '48Hrs')









   select * from  hire_packages 

 select * from Hire_Package

 -----------------------------------------------------

  create table Tour_Type
 (Tour_Type_id int identity,
 Tour_Type_Name varchar(35),
 Tour_Type_Distance int,
 constraint Tour_Type_id_pk primary key(Tour_Type_id));

 alter table Tour_Type alter column Tour_Type_Distance varchar(15);


 insert into Tour_Type ( Tour_Type_Name, Tour_Type_Distance ) values ( 'Long Tour', '700km' );
  insert into Tour_Type ( Tour_Type_Name, Tour_Type_Distance ) values ( 'Day Tour', '250KM' );
   insert into Tour_Type ( Tour_Type_Name, Tour_Type_Distance ) values ( 'Week Tour', '1500KM' );


 select * from Tour_Type
 select * from Hire_Package


 --------------------------------------------------------------

create table Hire_Payment
 (HPayment_id int identity,
  Hire_id int,
  HPayment_base_charge float,
  HPayment_Date datetime,
  Customer_id int,
  Driver_id int,
  HPayment_StRead float,
  HPayment_EnRead float,
  HPayment_NoOfReading float,
  HPayment_OtherCharge float,
  HPayment_Type varchar(35),
  HPayment_Total float
  constraint HPayment_id_pk primary key(HPayment_id),
  constraint Hire_id_fk foreign key(Hire_id) references Hire(Hire_id),
 constraint Cus_id_fk foreign key(Customer_id) references Customer(Customer_id),
 constraint dri_id_fk foreign key(driver_id) references driver(driver_id));


 select hire_payment.hire_payment_id , customer.customer_name ,hire_packages.hp_name ,
 hire_payment.hire_payment_base_charge , hire_payment.hire_waiting_charge ,  
 hire_payment.extra_km ,hire_payment.extra_km * 300 as Extra_KM_Charge,hire_payment.over_night_stay_charge ,
 hire_payment.hire_payment_base_charge+ hire_waiting_charge + extra_km_charge + over_night_stay_charge 
 as total_amount ,hire_payment.hire_payment_date from hire_payment 
 join hire on  hire.hire_id = hire_payment.hire_id 
 join hire_packages on hire_packages.hp_id = hire.hp_id 
 join customer on customer.customer_id = hire_payment.customer_id

 -----------------------------------------------

 select * from customer
  select * from hire
   select * from driver




 select * from hire_payment where hire_payment_id = '2'








 ---------------------------------------------------------------------------------

 select Hire_Payment.HPayment_id, hire.hire_id , Hire_Payment.HPayment_base_charge , HPayment_Date, 
 customer.Customer_Name , driver.driver_Name , Hire_Payment.HPayment_StRead , HPayment_EnRead , HPayment_EnRead - HPayment_StRead as HPayment_NoOfReading , 
 HPayment_OtherCharge , HPayment_Type ,  HPayment_base_charge + HPayment_OtherCharge as  HPayment_Total from Hire_Payment join Hire on Hire.Hire_id = Hire_Payment.Hire_id
 join customer on Hire_Payment.Customer_id = Customer.Customer_id 
 join Driver on Hire_Payment.Driver_id = Driver.Driver_id


 ------------------------------------------------------------------------------------------
 insert into Hire_Payment( Hire_id, HPayment_base_charge, HPayment_Date, Customer_id, Driver_id,HPayment_StRead,
 HPayment_EnRead, HPayment_OtherCharge, HPayment_Type ) values
  ( '3', '3500' ,'2022-10-27','6','5','50','125','9500','card');





  insert into Hire_Payment ( Hire_id, HPayment_base_charge, HPayment_Date, Customer_id, Driver_id,HPayment_StRead,
 HPayment_EnRead, HPayment_OtherCharge, HPayment_Type ) values 
  ( '4', '4000' ,'2022-11-5','7','3','152','480','15900','card');

  select * from hire
  select * from customer
  select * from Rates
  select * from driver

  delete from Hire_Payment where HPayment_id = '1'
    delete from Rent_Type where Rent_type_id = '10'

	select * from Ren


     select hire_payment.hire_payment_id , customer.customer_name ,hire_packages.hp_name ,
	 hire_payment.hire_payment_base_charge , hire_payment.hire_waiting_charge ,  
	 hire_payment.extra_km ,hire_payment.extra_km * 300 as Extra_KM_Charge,hire_payment.over_night_stay_charge ,
	 hire_payment.hire_payment_base_charge+ hire_waiting_charge + extra_km_charge + over_night_stay_charge 
	 as total_amount ,hire_payment.hire_payment_date from hire_payment
	  join hire on  hire.hire_id = hire_payment.hire_id join hire_packages 
	  on hire_packages.hp_id = hire.hp_id join customer on customer.customer_id = hire_payment.customer_id









     select hire_payment.hire_payment_id , customer.customer_name ,hire_package.hp_name ,hire_payment.hire_payment_base_charge , hire_payment.hire_waiting_charge ,  hire_payment.extra_km ,hire_payment.extra_km * 300 as Extra_KM_Charge,hire_payment.over_night_stay_charge ,hire_payment.hire_payment_base_charge+ hire_waiting_charge + extra_km_charge + over_night_stay_charge as total_amount ,hire_payment.hire_payment_date from hire_payment join hire on  hire.hire_id = hire_payment.hire_id join hire_packages on hire_packages.hp_id = hire.hp_id join customer on customer.customer_id = hire_payment.customer_id

	     select hire_payment.hire_payment_id , customer.customer_name ,hire_packages.hp_name ,
		 hire_payment.hire_payment_base_charge , hire_payment.hire_waiting_charge , 
		  hire_payment.extra_km ,hire_payment.extra_km * 300 as Extra_KM_Charge,
		  hire_payment.over_night_stay_charge ,
		  hire_payment.hire_payment_base_charge+ hire_waiting_charge + extra_km_charge + over_night_stay_charge as total_amount ,
		  hire_payment.hire_payment_date from hire_payment join hire on  hire.hire_id = hire_payment.hire_id 
		  join hire_packages on hire_packages.hp_id = hire.hp_id 
		  join customer on customer.customer_id = hire_payment.customer_id


 -----------------------
 select Rent_payment.rp_id, Rent_payment.rpDrivercharge, customer.customer_name, 
  Rent.Rent_id, Rent_payment.rp_date, Rent_payment.rpBasecharge, Rent_payment.rp_Type , rpBasecharge + rpDrivercharge as  rp_Total_Charge
  from Rent_payment join customer on Rent_payment.customer_id = customer.customer_id 
  join Rent on Rent_payment.Rent_id = Rent.Rent_id;
 ------------------


 select * from hire_payment;


 ------------------------------------------------------------------------------------






 select * from Hire_Payment








  ----------------------------


 create table driver
 (driver_id int identity,
 driver_name varchar(20),
 driver_teleno numeric(10),
 driver_address varchar(60),
 driver_licence_no varchar(8),
 driver_rate float,
 driver_overNightRate float,
 driver_waitingCharge float,
 constraint driver_id_pk primary key(driver_id));

 ------------------------------------------------------


 constraint vechicle_id_pk primary key(vechicle_id),


 sp_rename 'driver.driver_rent','driver_rate','COLUMN';

 sp_rename 'driver.diver_rent',

ALTER TABLE driver
DROP CONSTRAINT campany_fk;
alter table rates drop column perweek,permonth
select * from Rates

alter table  rates add amount float

 select * from vechicle_type; 


 select vt_id as id ,vt_name as name from vechicle_type 


 select * from driver;


 ---------------------------------

  create table Rent_payment
 (rp_id int identity,
 Rent_id int,
 rpBasecharge float,
 rp_date datetime,
 rpDrivercharge float,
 customer_id int,
 rp_Type varchar,
 rp_Total_Charge float,
 constraint rp_id_pk primary key(rp_id),
 constraint rent_id_fk foreign key(rent_id) references Rent(rent_id),
 constraint cudtomer_id_fk foreign key(customer_id) references customer(customer_id));


 select Rent_payment.rp_id, Rent_payment.rpDrivercharge, customer.customer_name,
  Rent.Rent_id, Rent_payment.rp_date, Rent_payment.rpBasecharge, Rent_payment.rp_Type , rpBasecharge + rpDrivercharge as  rp_Total_Charge
  from Rent_payment join customer on Rent_payment.customer_id = customer.customer_id 
  join Rent on Rent_payment.Rent_id = Rent.Rent_id;



  select * from Rent

   insert into rent ( vt_id , driver_id , RentStartDate , RentEndDate,rent_days )
    values ( '4' , '3' , '2022-10-17' , '2022-10-24' , '4')


	 update rent set vt_id ='4', driver_id = '3' , RentStartDate ='2022-10-24' , RentEndDate = '2022-10-25' , rent_Days = ''  where rent_id ='0'


   insert into rent_payment ( rpDrivercharge , customer_id, rent_id, rp_Date, rpBasecharge , rp_Type ) 
   values ('4000' , '7' , 'System.Data.DataRowView' , '2022-10-25' , '5000' ,  'chash')


insert into Rent_payment ( rpDrivercharge, customer_id ,Rent_id , rp_date, rpBasecharge, rp_Type ) values
( '4000','7', '3', '2022-10-26', '2000', 'chash' )


select * from customer
select * from Rent_payment



   insert into rent_payment ( rpDrivercharge , customer_id, rent_id, rp_Date, rpBasecharge , rp_Type ) 
   values ('2500' , '1' , '4' , '24-oct-22' , '5000' ,  'chash')


   insert into Rent_payment(Rent_id, rpBasecharge, rp_date, rpDrivercharge, customer_id, rp_Type) values 
   ( '2' , '5000', '2022-10-17 10:10' , '2500', '1' , ' chash')

   insert into Rent_payment(Rent_id , rpBasecharge ,rp_date ,rpDrivercharge ,customer_id, rp_Type,rp_Total_Charge)
    values ( '2' , '5000', '2022-10-17 10:10' , '25000', '1' , ' chash', '10000')


	  insert into rent_payment ( rpDrivercharge , customer_id, rent_id, rp_Date, rpBasecharge , rp_Type ) values
	   ('6000' , '1' , '4' , '2022-10-05' , '50000' ,  'card')



	     insert into rent_payment ( rpDrivercharge , customer_id, rent_id, rp_Date, rpBasecharge , rp_Type ) 
		 values ('6000' , '1' , '10' , '2022-10-29' , '5060' ,  'chash')

sele

		   insert into rent_payment ( rpDrivercharge , customer_id, rent_id, rp_Date, rpBasecharge , rp_Type )
		    values ('2500' , '1' , '3' , '2022-10-11' , '30000' ,  'chash')


			  insert into rent_payment ( rpDrivercharge , customer_id, rent_id, rp_Date, rpBasecharge , rp_Type ) 
			  values ('5000' , '6' , '4' , '2022-10-24' , '8000' ,  'chash')


		   SELECT  SUM (perday + no_of_days) as amount FROM rates;
SELECT rates,(perday + no_of_days) as amount FROM Hire2




	    alter table Rent_payment alter column rp_type varchar (30);









   select * from Rent
      select * from customer
	     select * from Rent_payment



     insert into rent_payment ( rpDrivercharge , customer_name, rent_id, rp_Date, rpBasecharge , rp_Type ) 
	 values ('2000' , '1' , 'System.Data.DataRowView' , '2022-10-24' , '5000' ,  'card')







 select Rent_payment.rp_id, Rent_payment.rpDrivercharge, customer.customer_name, Rent.Rent_id,
  Rent_payment.rp_date, Rent_payment.rpBasecharge, Rent_payment.rp_Type, Rent_payment.rp_Total_Charge
  from Rent_payment join customer on Rent_payment.customer_id = customer.customer_id
  join Rent on Rent_payment.Rent_id = Rent.Rent_id;


    select Rent_payment.rp_id, Rent_payment.rpDrivercharge, customer.customer_name, Rent.Rent_id, Rent_payment.rp_date, Rent_payment.rpBasecharge, Rent_payment.rp_Type, Rent_payment.rp_Total_Charge from Rent_payment join customer on Rent_payment.customer_id = customer.customer_id join Rent on Rent_payment.Rent_id = Rent.Rent_id; 




  select Rent_payment.customer_id , Rent_payment.rp_base_charge,
  Rent_payment.rpdrivercharge  ,Rent_payment.total_charge, Rent_payment.rent_payment_date
   from Rent_payment join customer on Rent_payment.customer_id = customer.customer_id 

   select * from Rent_payment

------------------------------------------------------


 create table Rent
 (rent_id int identity,
 vt_id int,
 rent_days int,
 driver_id int,
 RentStartDate datetime,
 RentEndDate datetime,
 Rent_Type_id int,
 constraint rent_id_pk primary key(rent_id),
 constraint driver_id_fk foreign key(driver_id) references driver(driver_id),
 constraint veT_id_fk foreign key(vt_id) references vechicle_Type(vt_id),
 constraint Rent_Type_id_fk foreign key(Rent_Type_id) references Rent_Type(Rent_Type_id));

 alter table Rent alter column RentStartDate datetime (30);



 select * from Rent
  select * from vechicle_type
   select * from driver
   select * from Rent_Type



 insert into Rent(vt_id,rent_days,driver_id,RentStartDate,RentEndDate,Rent_Type_id)values
('6','10','1','24-oct-22', '26-oct-22','8');
insert into Rent values ('4','2','2','17-oct-22 10:10', '20-oct-22 10:10','7');









  select Rent.rent_id, vechicle_type.vt_name , driver.driver_name , RentStartDate , 
  RentEndDate, rent_days from Rent join driver on driver.driver_id = Rent.driver_id 
  join vechicle_type on vechicle_type.vt_id = Rent.vt_id

   select Rent.rent_id, vechicle_type.vt_name , driver.driver_name , RentStartDate , 
   RentEndDate, rent_days from Rent join driver on driver.driver_id = Rent.driver_id 
   join vechicle on vechicle.vechicle_id = Rent.vechicle_id join vechicle_type 
   on vechicle_type.vt_id = vechicle.vt_id_fk 



   select Rent.rent_id, vechicle_type.vt_name , driver.driver_name , RentStartDate , 
   RentEndDate, rent_days from Rent join driver on driver.driver_id = Rent.driver_id 
   join vechicle on vechicle.vechicle_id = Rent.vechicle_id join vechicle_type 
   on vechicle_type.vt_id = vechicle.vt_id_fk 





 -----------------------

 create table Rent_Type
 (Rent_Type_id int identity,
 Rent_Type_Name varchar,
 constraint Rent_Type_pk primary key(Rent_Type_id));

 select * from Rent_Type


 alter table Rent_Type alter column rent_type_Name varchar (15);

 insert into Rent_Type(Rent_Type_Name) values ('with Driver');

insert into Rent_Type values
('with Out Driver');
('bus'),
('bike'),
('lorry');

 select * from Rent_Type;

 ---------------------------------------------------------------------


 select vechicle. vechicle_id as ID ,vechicle_no as Number,
 vechicle_type.vt_name from vechicle join vechicle_type on 
 vechicle.vt_id_fk = vechicle_type.vt_id







 delete from rent where rent_id = '6'

  select * from Rent

 select Rent.rent_id, vechicle_type.vt_name,driver.driver_name ,RentStartDate , RentEndDate  from Rent 
join driver on driver.driver_id = Rent.driver_id
join vechicle on vechicle.vechicle_id = Rent.vechicle_id
join vechicle_type on vechicle_type.vt_id = vechicle.vt_id_fk



 select*  from Rent 
join driver on driver.driver_id = Rent.driver_id
join vechicle on vechicle.vechicle_id = Rent.vechicle_id
join vechicle_type on vechicle_type.vt_id = vechicle.vt_id_fk


select hire.hire_id, hire_packages.hp_name, vechicle.vechicle_no, driver.driver_name from hire
 join hire_packages on hire_packages.hp_id = hire.hp_id
 join vechicle on vechicle.vechicle_id = hire.vechicle_id
 join Driver on driver.driver_id = hire.driver_id


 select vechicle. vechicle_id as ID ,vechicle_no as Number,vechicle_type.vt_name from 
 vechicle join vechicle_type on vechicle.vt_id_fk = vechicle_type.vt_id

 select * from vechicle;
 select * from vechicle_type;





 {"Conversion failed when converting the varchar value 'System.Windows.Forms.Label, Text: 8' to data type int."}







 select * from hire




 select * from hire_payment
 join hire on hire.hire_id = hire_payment.hire_id




 select hire_payment.hire_payment_id, hire_packages.hp_name , hire_payment.hire_payment_base_charge , 
 hire_payment.hire_waiting_charge , hire_payment.extra_km , hire_payment.extra_km_charge , 
 hire_payment.over_night_stay_charge , hire_payment.hire_payment_date from hire_payment
 join hire on  hire.hire_id = hire_payment.hire_id
 join hire_packages on hire_packages.hp_id = hire.hp_id







 select hire.hire_id , hire_payment.hire_payment_base_charge , hire_payment.hire_waiting_charge ,
  hire_payment.extra_km , hire_payment.extra_km_charge , hire_payment.over_night_stay_charge ,
   hire_payment.hire_payment_date from hire_payment
 join hire on hire.hire_id = hire_payment.hire_id
 



 select hire_packages.hp_id, vechicle.vechicle_no, driver.driver_name from hire join hire_packages on hire_packages.hp_id = hire.hp_id join vechicle on vechicle.vechicle_id = hire.vechicle_id join Driver on driver.driver_id = hire.driver_id 

 select * from hire where hire_id = '1'


  select Rent.rent_id, vechicle_type.vt_name , driver.driver_name , RentStartDate , RentEndDate from Rent join driver on driver.driver_id = Rent.driver_id join vechicle on vechicle.vechicle_id = Rent.vechicle_id join vechicle_type on vechicle_type.vt_id = vechicle.vt_id_fk 
alter table hire_payment add total_amount 
  select * from hire_payment;

  select hire_payment.hire_payment_id , customer.customer_name , hire_packages.hp_name , 
  hire_payment.hire_payment_base_charge , hire_payment.hire_waiting_charge , 
  hire_payment.extra_km , hire_payment.extra_km * 300 as Extra_KM_Charge,
   hire_payment.over_night_stay_charge ,   hire_payment.hire_payment_date from hire_payment 
   join hire on  hire.hire_id = hire_payment.hire_id 
   join hire_packages on hire_packages.hp_id = hire.hp_id
   join customer on customer.customer_id = hire_payment.customer_id




   select hire_payment.hire_payment_id , customer.customer_name , hire_packages.hp_name , hire_payment.hire_payment_base_charge , hire_payment.hire_waiting_charge ,  hire_payment.extra_km , hire_payment.extra_km * 300 as Extra_KM_Charge,hire_payment.over_night_stay_charge , hire_payment.hire_payment_base_charge+ hire_waiting_charge + extra_km_charge + over_night_stay_charge  as total_amount ,hire_payment.hire_payment_date from hire_payment join hire on  hire.hire_id = hire_payment.hire_id join hire_packages on hire_packages.hp_id = hire.hp_id join customer on customer.customer_id = hire_payment.customer_id




   insert into hire_payment (hire_id, hire_payment_base_charge ,  hire_waiting_charge, extra_km, 
   over_night_stay_charge, hire_payment_date  ) values 
   ('1', '50000' , '1200' , '10' , '750' , '2022-07-19' )

   insert into hire_payment (customer_id, hire_id , hire_payment_base_charge ,  hire_waiting_charge, extra_km, over_night_stay_charge, hire_payment_date  )
   values ( '8','50000','500','10','500','2022-05-14 13:00:00:000','2022-05-10 12:00:00:000')

   insert into hire_payment (customer_id, hire_id , hire_payment_base_charge , 
   hire_waiting_charge, extra_km, over_night_stay_charge, hire_payment_date  )
   values ('1', '3'  , '5000' , '500' , '15' , '1500' , '2022-05-10 ' )

   insert into hire_payment (customer_id, hire_id , hire_payment_base_charge ,  hire_waiting_charge, extra_km, over_night_stay_charge, hire_payment_date  ) values ('1', '1'  , '5000' , '1000' , '10' , '500' , '2022-07-20' )


   insert into hire_payment (customer_id, hire_id , hire_payment_base_charge ,  hire_waiting_charge, 
   extra_km, over_night_stay_charge, hire_payment_date  )
    values ('1', '1'  , '5' , '7' , '4' , '5' , '2022-07-19' )

	alter table hire_payment add hp_id int
	select * from hire_payment

	alter table hire_payment add  constraint hap_id_fk foreign key(hp_id) 
	references hire_packages(hp_id);
alter table hire_payment drop column hire_id
	alter table hire_payment drop constraint hire_id_fk


	alter table hire_payment add  hire_id int 
	alter table hire_payment add constraint hire_id_fk foreign key(hire_id) 
	references hire(hire_id);

	insert into hire_payment (customer_id, hp_id , hire_payment_base_charge ,  hire_waiting_charge, extra_km, over_night_stay_charge, hire_payment_date  ) 
	values ('5', '3'  , '5' , '5' , '5' , '5' , '2022-07-14' )

 select rent_payment.rp_id , rent.rent_id , rent_payment.rent_charge , rent_payment.rp_date, 
 rent_payment.rp_base_charge from  rent_payment 
 join rent on rent.rent_id = rent_payment.rent_id 


 alter table rent_payment drop column rent_payment_type

  sp_rename 'rent_payment.rent_payment_Tcharge','Total_charge','COLUMN';


 select * from Rent_payment
 alter table rent_payment add rent_payment_date datetime
 select Rent_payment.customer_id , Rent_payment.rp_base_charge,Rent_payment.rpdrivercharge  ,Rent_payment.total_charge, Rent_payment.rent_payment_date from Rent_payment
 join customer on Rent_payment.customer_id = customer.customer_id
 
 insert into rent_payment ( customer_id, rp_base_charge , rp_base_charge,rpdrivercharge,rent_payment_date ) 
 values ( '1' , '5000' , '2022-07-19' , '6000')

   insert into rent_payment ( customer_id, rp_base_charge , rp_base_charge,rpdrivercharge,rent_payment_date ) 
   values ( '4' , '5000' , '2022-07-19' , '1000')


select * from customer
select * from hire

insert into hire_payment (customer_id, hp_id , hire_payment_base_charge ,  
hire_waiting_charge, extra_km, over_night_stay_charge, hire_payment_date  )
 values ('1', '1'  , '5' , '5' , '5' , '5' , '2022-07-19' )

   select * from hire
    select * from hire_package 
   select * from hire_payment

   alter table hire_payment add total_amount float






   select hire_payment.hire_payment_id , customer.customer_name ,hire_packages.hp_name ,hire_payment.hire_payment_base_charge , hire_payment.hire_waiting_charge ,  hire_payment.extra_km ,hire_payment.extra_km * 300 as Extra_KM_Charge,hire_payment.over_night_stay_charge ,hire_payment.hire_payment_base_charge+ hire_waiting_charge + extra_km_charge + over_night_stay_charge as total_amount ,hire_payment.hire_payment_date from hire_payment join hire on  hire.hire_id = hire_payment.hire_id join hire_packages on hire_packages.hp_id = hire.hp_id join customer on customer.customer_id = hire_payment.customer_id







































   update rent set vechicle_id ='4', driver_id = '5' , RentStartDate ='2022-07-06' , RentEndDate = '2022-07-24' , rent_days = '12'  where rent_id ='4'


    select Rates.rate_id,perday,no_of_days,amount ,vechicle_type.vt_name 
	as vt_name from Ratesjoin vechicle_type 
	on vechicle_type .vt_id = rates.vt_id 


  insert into rent_payment ( customer_id, rp_base_charge  ,rpdrivercharge ,rent_payment_date,total_amount)
   values ( '1' , '5000' , '1000' , '2022.0')



	select hire.hire_id  , vechicle.vechicle_id,driver.driver_id , hire.hireStartDate ,hire.hireEndDate,hire.no_of_days from hire join  vechicle on vechicle.vechicle_id = hire.vechicle_id join driver on driver.driver_id = hire.driver_id

	select * from hire_packages
select * from vechicle
select * from driver
select * from hire

	  insert into hire ( hp_id  , vechicle_id , driver_id , hireStartDate , hireEndDate ,no_of_days  ) 
	  values ( '3' , '9' , '1' , '2022-07-19' , '2022-07-21' , '02' ) 

	  insert into hire (hp_id ,vechicle_id,driver_id,hireStartDate,hireEndDate,no_of_days) values 
	  ( '4','6','5','2022-05-10 12:00:00:000','2022-05-14 13:00:00:000','02')

	   update hire_packages set hp_name ='batticaloa to kathiragama' hp_amount = '65000'  where hp_id = '5'


select * from hire



update rent set vechicle_id = '10' , driver_id = '4' , RentStartDate = '2021-09-10' ,
 RentEndDate = 2021-09-14 where rent_id = '15';
update customer set customer_name ='thuva' where customer_id = '7';

 update driver set driver_Name ='kukanan' , driver_teleno = '749876548' ,driver_Address = 'kandy' , driver_Licence_No = 'AW-5685' , driver_rate = '50000', driver_over_night_charge='500',driver_waiting_charge='600'  where Driver_id = '8'





 select * from Rent;
 select * from vechicle;

 -------------------------------------------------

 create table Rent_payment
 (rp_id int identity,
 Rent_id int,
 rpBasecharge float,
 rp_date datetime,
 rpDrivercharge float,
 customer_id int,
 rp_Type varchar,
 rp_Total_Charge float,
 constraint rp_id_pk primary key(rp_id),
 constraint rent_id_fk foreign key(rent_id) references Rent(rent_id),
 constraint cudtomer_id_fk foreign key(customer_id) references customer(customer_id));

----------------------------------------------------------------










 sp_rename 'Rent_payment.rpbasecharge','Rent_charge','COLUMN';
 select * from Rent_payment

 alter table rent_payment add rp_base_charge float

  delete from rent_payment where rp_id = '5'



insert into rent_payment ( rp_id , rent_id , rent_charge , rp_Date , rpDriverCharge ) values ( '22' , '7500' , '2021-08-15' , '1500');



 insert into rent ( vechicle_id , driver_id , RentStartDate , RentEndDate ) values ( '" + vechicleNoBox.SelectedValue.ToString() + "' , '" + driverNameBox.SelectedValue.ToString() + "' , '" + rentStartBox.Text + "' , '" + rentEndBox.Text + "')");


  insert into rent_payment ( rent_id , rent_charge , rp_Date , rpDriverCharge ) values ( 'System.Data.DataRowView' , '8500' , '2021-08-24' , '1500')

   insert into rent_payment ( rent_id , rent_charge , rp_Date , rpDriverCharge ) values ( '22' , '8500' , '2021-08-27' , '1500')


   select rent_payment.rp_id , rent.rent_id , rent_payment.rent_charge , rent_payment.rp_date, rent_payment.rpDriverCharge from  rent_payment
   join rent on rent.rent_id = rent_payment.rent_id

   select * from rent_payment where rent_payment_id = '3'

   ---------------------------------------

 create table customer
 (customer_id int identity,
 customer_name varchar(35),
 customer_address varchar(60),
 customer_teleno numeric(10),
 constraint customer_id_pk primary key(customer_id));
 select * from customer; 
 -----------------------------------------------------------------------

   insert into customer ( customer_name , customer_id, rent_id, rp_Date, rpBasecharge , rp_Type ) 
   values ('2500' , '1' , 'System.Data.DataRowView' , '2022-10-11' , '30000' ,  'chash')



alter table rent_payment drop column rent_charge


ALTER TABLE customer
DROP CONSTRAINT cam_id_fk;
 select * from customer; 

 select * from driver

ALTER TABLE customer
DROP column campany_id;





alter table rent_payment add customer_id int
alter table rent_payment add rent_payment_type varchar(15)
alter table rent_payment add rent_payment_Tcharge int
alter table rent_payment add constraint cus_id_fk foreign key(customer_id) references customer(customer_id);





select * from driver
alter table driver add driver_over_night_charge float
alter table driver add driver_waiting_charge float


select * from hire

alter table hire drop column min_km,mix_km,hire_waiting_charge,hire_waiting_time;


select * from rent

alter table hire_packages add hp_amount float, hp_mix_KM float,hp_min_KM float























 alter table company 


 create table hire_packages
 (hp_id int identity,
 hp_name varchar(20),
 constraint hp_id_Pk primary key(hp_id));
 select * from  hire_packages;



 alter table hire_packages alter column hp_name varchar(80);


 insert into hire_packages ( hp_name) values ('Airport Drop And Pickup' ) ;

 insert into hire_packages ( hp_name) values  ('Batticaloa to colombo');

delete from hire_packages where hp_id = '6'




 create table hire
 (hire_id int identity,
 min_km float,
 mix_km float,
 hire_waiting_charge float,

 hp_id int,
 vechicle_id int,
 driver_id int,
 constraint hire_id_pk primary key(hire_id),
 constraint hp_id_fk foreign key(hp_id) references hire_packages(hp_id),
 constraint vechi_id_fk foreign key(vechicle_id) references vechicle(vechicle_id),
 constraint driver_fk foreign key(driver_id) references driver(driver_id));


 alter table hire add hireStartDate datetime;
  alter table hire add  hireEndDate datetime;
  alter table hire add Hire_waiting_time time;
  alter table hire add no_of_days int;


   insert into hire ( hp_id  , vechicle_id , driver_id , hireStartDate , hireEndDate , Hire_waiting_time ) values ( '7' , '17' , '1' , '2021-08-11' , '2021-08-14' , '') 


   alter table hire_packages drop column hp_mix_KM,hp_min_KM
 select * from hire_packages

 select * from hire;



 create table hire_payment
 (hire_payment_id int identity,
  hire_payment_base_charge float,
  hire_payment_waiting_charge float,
  extra_km_charge float,
  over_night_stay_charge float,
  hire_payment_date datetime,
  hire_id int,
  constraint hire_payment_id_pk primary key(hire_payment_id),
  constraint hire_id_fk foreign key(hire_id) references hire(hire_id));
  select * from hire_payment;

  alter table hire_payment add customer_id int
  alter table hire_payment add constraint customer_id foreign key (customer_id) references customer(customer_id);

    alter table hire_payment add driver_id int
  alter table hire_payment add constraint driver_id foreign key (driver_id) references driver(driver_id);

  sp_rename 'hire_payment.hire_payment_waiting_charge','hire_waiting_charge','column';
  alter table hire_payment add extra_km int;

  insert into hire_payment (hire_id,hire_waiting_charge,extra_km, extra_km_charge,over_night_stay_charge,hire_payment_date) values ( 1 , 1500 , 25 , 12500, 1000, 2021-08-09);

  insert into hire_payment (hire_id, hire_payment_base_charge,  hire_waiting_charge, extra_km, extra_km_charge, over_night_stay_charge, hire_payment_date  ) values ('1', '18000' , '800' , '30' , '15000' , '800' , '2021-08-19' )
  select * from customer


  create table payment
  (payment_id int identity,
   payment_amount float,
   payment_date datetime,
   customer_id int,
   hire_payment_id int,
   rp_id int,
   constraint payment_id_pk primary key(payment_id),
   constraint customer_id_fk foreign key(customer_id) references customer(customer_id),
   constraint hire_payment_fk foreign key(hire_payment_id) references hire_payment(hire_payment_id),
  constraint rp_id_fk foreign key(rp_id ) references rent_payment(rp_id));
  select * from payment;

  -------------------------------------------------------------------------------------

  insert into vechicle_type(vt_name) values ('car');
  select * from vechicle_type
 select vt_id as id ,vt_name as name from vechicle_type 

  update vechicle_type set vt_name ='BMW Bike' where vt_id = '30';
   update vechicle_type set vt_name ='lorry' where vt_id = '5';

   delete from  vechicle_type where vt_id ='5';

   delete from hire_packaegs where hp_id = '6'

   select * from hire_packaegs
   delete from vechicle_type

insert into vechicle_type(vt_name)values
('car');
insert into vechicle_type values
('van'),
('bus'),
('bike');
select * from vechicle_type;


insert into customer (customer_name,customer_address,customer_teleno) values
('shanjeef','kirankulam',0756508688);


insert into Rent ( vechicle_id,rent_days,driver_id,RentStartDate,RentEndDate) values
('10' , 01 , '1' , 01/09/2021, 02/09/2021 );
insert into Rent values
(11 , 4 , 3 , 2021-09-10 , 2021-09-14);

select * from customer



insert into vechicle ( vechicle_no , vt_id_fk) values ('AAA_000', 21);

select vechicle. vechicle_id as ID ,vechicle_no as Number,vechicle_type.vt_name from vechicle join vechicle_type on vechicle.vt_id_fk = vechicle_type.vt_id
   select * from vechicle_type;


   select * from vechicle where vechicle_id = ''


   update vechicle set vechicle_no ='', vt_id_fk ='' where vechicle_id =

  select * from customer;
  select * from driver


  update customer set customer_name ='thuva' where customer_id = '7';

  delete from  customer where customer_id ='8';

  select * from Rent

  select vechicle_id as id ,vt_name as name from vechicle_type		




  select * from vechicle_type
  select * from driver
  select * from rent



   insert into rent ( vechicle_id , driver_id , RentStartDate , RentEndDate ) values ( '" + vechicleNoBox.SelectedValue.ToString() + "' , '" + driverNameBox.SelectedValue.ToString() + "' , '" + rentStartBox.Text + "' , '" + rentEndBox.Text + "')");
   

   select Rent_payment.customer_id , Rent_payment.rp_base_charge,Rent_payment.rpdrivercharge  ,Rent_payment.total_charge, Rent_payment.rent_payment_date from Rent_payment join customer on Rent_payment.customer_id = customer.customer_id 

   select * from hire_payment join customer on hire_payment.customer_id = customer.customer_id






