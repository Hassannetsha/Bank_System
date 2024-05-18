/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     5/15/2024 7:42:08 PM                         */
/*==============================================================*/
use BankSystem;

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACCOUNT') and o.name = 'FK_ACCOUNT_REFERENCE_CUSTOMER')
alter table ACCOUNT
   drop constraint FK_ACCOUNT_REFERENCE_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BANK_ADDRESSES') and o.name = 'FK_BANK_ADD_REFERENCE_BANK')
alter table BANK_ADDRESSES
   drop constraint FK_BANK_ADD_REFERENCE_BANK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BRANCH') and o.name = 'FK_BRANCH_REFERENCE_BANK')
alter table BRANCH
   drop constraint FK_BRANCH_REFERENCE_BANK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BRANCH_CUSTOMER') and o.name = 'FK_BRANCH_C_REFERENCE_CUSTOMER')
alter table BRANCH_CUSTOMER
   drop constraint FK_BRANCH_C_REFERENCE_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BRANCH_CUSTOMER') and o.name = 'FK_BRANCH_C_REFERENCE_BRANCH')
alter table BRANCH_CUSTOMER
   drop constraint FK_BRANCH_C_REFERENCE_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BRANCH_LOANS') and o.name = 'FK_BRANCH_L_REFERENCE_BRANCH')
alter table BRANCH_LOANS
   drop constraint FK_BRANCH_L_REFERENCE_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BRANCH_LOANS') and o.name = 'FK_BRANCH_L_REFERENCE_LOAN')
alter table BRANCH_LOANS
   drop constraint FK_BRANCH_L_REFERENCE_LOAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CREDIT_CARD') and o.name = 'FK_CREDIT_C_REFERENCE_CREDIT_C')
alter table CREDIT_CARD
   drop constraint FK_CREDIT_C_REFERENCE_CREDIT_C
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CREDIT_CARD_ACCOUNT') and o.name = 'FK_CREDIT_C_REFERENCE_ACCOUNT')
alter table CREDIT_CARD_ACCOUNT
   drop constraint FK_CREDIT_C_REFERENCE_ACCOUNT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLOYEE') and o.name = 'FK_EMPLOYEE_REFERENCE_BRANCH')
alter table EMPLOYEE
   drop constraint FK_EMPLOYEE_REFERENCE_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOAN') and o.name = 'FK_LOAN_REFERENCE_LOANACCO')
alter table LOAN
   drop constraint FK_LOAN_REFERENCE_LOANACCO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOAN') and o.name = 'FK_LOAN_REFERENCE_CUSTOMER')
alter table LOAN
   drop constraint FK_LOAN_REFERENCE_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOAN') and o.name = 'FK_LOAN_REFERENCE_EMPLOYEE')
alter table LOAN
   drop constraint FK_LOAN_REFERENCE_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOANACCOUNT') and o.name = 'FK_LOANACCO_REFERENCE_ACCOUNT')
alter table LOANACCOUNT
   drop constraint FK_LOANACCO_REFERENCE_ACCOUNT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRANSCATION') and o.name = 'FK_TRANSCAT_REFERENCE_ACCOUNT')
alter table TRANSCATION
   drop constraint FK_TRANSCAT_REFERENCE_ACCOUNT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACCOUNT')
            and   type = 'U')
   drop table ACCOUNT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BANK')
            and   type = 'U')
   drop table BANK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BANK_ADDRESSES')
            and   type = 'U')
   drop table BANK_ADDRESSES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BRANCH')
            and   type = 'U')
   drop table BRANCH
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BRANCH_CUSTOMER')
            and   type = 'U')
   drop table BRANCH_CUSTOMER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BRANCH_LOANS')
            and   type = 'U')
   drop table BRANCH_LOANS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CREDIT_CARD')
            and   type = 'U')
   drop table CREDIT_CARD
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CREDIT_CARD_ACCOUNT')
            and   type = 'U')
   drop table CREDIT_CARD_ACCOUNT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CUSTOMER')
            and   type = 'U')
   drop table CUSTOMER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMPLOYEE')
            and   type = 'U')
   drop table EMPLOYEE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOAN')
            and   type = 'U')
   drop table LOAN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOANACCOUNT')
            and   type = 'U')
   drop table LOANACCOUNT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TRANSCATION')
            and   type = 'U')
   drop table TRANSCATION
go


/*==============================================================*/
/* Table: ACCOUNT                                               */
/*==============================================================*/
create table ACCOUNT (
   ACCOUNTID            numeric(15)          not null identity(1,1),
   CUSTOMERID           numeric(15)          null,
   BALANCE              numeric(15)          not null,
   TYPE                 varchar(10)          not null,
   INTERESTRATE         float                null,
   OPENDATE             datetime             null,
   constraint PK_ACCOUNT primary key (ACCOUNTID)
)
go

/*==============================================================*/
/* Table: BANK                                                  */
/*==============================================================*/
create table BANK (
   CODE                 numeric(15)          not null identity(1,1),
   BANK_NAME            varchar(60)          not null,
   constraint PK_BANK primary key (CODE)
)
go

/*==============================================================*/
/* Table: BANK_ADDRESSES                                        */
/*==============================================================*/
create table BANK_ADDRESSES (
   BANK_ADDRESS         varchar(255)         not null,
   BANK_CODE            numeric(15)          not null,
   constraint PK_BANK_ADDRESSES primary key (BANK_ADDRESS, BANK_CODE)
)
go

/*==============================================================*/
/* Table: BRANCH                                                */
/*==============================================================*/
create table BRANCH (
   BRANCH_NUMBER        numeric(14)          not null identity(1,1),
   BANK_CODE            numeric(15)          null,
   BARNCH_ADDRESS       varchar(255)         not null,
   CITY                 varchar(25)          null,
   STATE                varchar(25)          null,
   ZIPCODE              numeric(10)          null,
   constraint PK_BRANCH primary key (BRANCH_NUMBER)
)
go

/*==============================================================*/
/* Table: BRANCH_CUSTOMER                                       */
/*==============================================================*/
create table BRANCH_CUSTOMER (
   BRANCH_NUMBER        numeric(14)          not null,
   CUST_SSN             numeric(15)          not null,
   constraint PK_BRANCH_CUSTOMER primary key (BRANCH_NUMBER, CUST_SSN)
)
go

/*==============================================================*/
/* Table: BRANCH_LOANS                                          */
/*==============================================================*/
create table BRANCH_LOANS (
   BRANCH_NUMBER        numeric(14)          not null,
   LOAN_NUMBER          numeric(10)          not null,
   constraint PK_BRANCH_LOANS primary key (BRANCH_NUMBER, LOAN_NUMBER)
)
go

/*==============================================================*/
/* Table: CREDIT_CARD                                           */
/*==============================================================*/
create table CREDIT_CARD (
   CREDICARDID          numeric(10)          not null,
   ACCOUNTID            numeric(15)          null,
   CREDITLIMIT          int                  null,
   MINPAYMENT           int                  null,
   INTERESTRATE         float                null,
   ISSUEDDATE           datetime             null,
   constraint PK_CREDIT_CARD primary key (CREDICARDID)
)
go

/*==============================================================*/
/* Table: CREDIT_CARD_ACCOUNT                                   */
/*==============================================================*/
create table CREDIT_CARD_ACCOUNT (
   ACCOUNTID            numeric(15)          not null,
   constraint PK_CREDIT_CARD_ACCOUNT primary key (ACCOUNTID)
)
go

/*==============================================================*/
/* Table: CUSTOMER                                              */
/*==============================================================*/
create table CUSTOMER (
   CUSTOMERID           numeric(15)          not null identity(1,1),
   FNAME                varchar(10)          not null,
   LNAME                varchar(10)          not null,
   CUSTOMER_ADDRESS     varchar(255)         not null,
   CUST_PHONE           numeric(12)          not null,
   EMAIL                varchar(30)          null,
   DATEOFBIRTH          datetime             null,
   NATIONALID           numeric(15)          null,
   constraint PK_CUSTOMER primary key (CUSTOMERID)
)
go

/*==============================================================*/
/* Table: EMPLOYEE                                              */
/*==============================================================*/
create table EMPLOYEE (
   EMPLOYEEID           numeric(10)          not null identity(1,1),
   BARNCH_NUMBER        numeric(14)          null,
   EMP_FNAME            varchar(10)          not null,
   EMP_LNAME            varchar(10)          not null,
   EMP_ADDRESS          varchar(255)         null,
   PHONENUMBER          numeric(11)          null,
   JOBTITLE             varchar(25)          null,
   EMP_EMAIL            varchar(255)         null,
   constraint PK_EMPLOYEE primary key (EMPLOYEEID)
)
go

/*==============================================================*/
/* Table: LOAN                                                  */
/*==============================================================*/
create table LOAN (
   LOAN_NUMBER          numeric(10)          not null identity(1,1),
   EMP_SSN              numeric(10)          null,
   ACCOUNTID            numeric(15)          null,
   CUSTOMERID           numeric(15)          null,
   LOAN_TYPE            varchar(30)          not null,
   LOAN_AMOUNT          numeric(10)          not null,
   INTERESTRATE         float                null,
   ORIGINATIONDATE      datetime             null,
   constraint PK_LOAN primary key (LOAN_NUMBER)
)
go

/*==============================================================*/
/* Table: LOANACCOUNT                                           */
/*==============================================================*/
create table LOANACCOUNT (
   ACCOUNTID            numeric(15)          not null,
   constraint PK_LOANACCOUNT primary key (ACCOUNTID)
)
go

/*==============================================================*/
/* Table: TRANSCATION                                           */
/*==============================================================*/
create table TRANSCATION (
   TRANSACTIONID        numeric(10)          not null,
   ACCOUNTID            numeric(15)          not null,
   TRANSACTION_DATE     timestamp            null,
   TRANSACTION_AMOUNT   numeric(15)          not null,
   TRANSACTION_TYPE     varchar(10)          not null,
   DESCRIPTION          varchar(255)         null,
   constraint PK_TRANSCATION primary key (TRANSACTIONID, ACCOUNTID)
)
go

alter table ACCOUNT
   add constraint FK_ACCOUNT_REFERENCE_CUSTOMER foreign key (CUSTOMERID)
      references CUSTOMER (CUSTOMERID)on delete cascade on update cascade
go

alter table BANK_ADDRESSES
   add constraint FK_BANK_ADD_REFERENCE_BANK foreign key (BANK_CODE)
      references BANK (CODE)on delete cascade on update cascade
go

alter table BRANCH
   add constraint FK_BRANCH_REFERENCE_BANK foreign key (BANK_CODE)
      references BANK (CODE)on delete cascade on update cascade
go

alter table BRANCH_CUSTOMER
   add constraint FK_BRANCH_C_REFERENCE_CUSTOMER foreign key (CUST_SSN)
      references CUSTOMER (CUSTOMERID)on delete cascade on update cascade
go

alter table BRANCH_CUSTOMER
   add constraint FK_BRANCH_C_REFERENCE_BRANCH foreign key (BRANCH_NUMBER)
      references BRANCH (BRANCH_NUMBER)on delete cascade on update cascade
go

alter table BRANCH_LOANS
   add constraint FK_BRANCH_L_REFERENCE_BRANCH foreign key (BRANCH_NUMBER)
      references BRANCH (BRANCH_NUMBER)on delete cascade on update cascade
go

alter table BRANCH_LOANS
   add constraint FK_BRANCH_L_REFERENCE_LOAN foreign key (LOAN_NUMBER)
      references LOAN (LOAN_NUMBER)on delete cascade on update cascade
go

alter table CREDIT_CARD
   add constraint FK_CREDIT_C_REFERENCE_CREDIT_C foreign key (ACCOUNTID)
      references CREDIT_CARD_ACCOUNT (ACCOUNTID)on delete cascade on update cascade
go

alter table CREDIT_CARD_ACCOUNT
   add constraint FK_CREDIT_C_REFERENCE_ACCOUNT foreign key (ACCOUNTID)
      references ACCOUNT (ACCOUNTID)on delete cascade on update cascade
go

alter table EMPLOYEE
   add constraint FK_EMPLOYEE_REFERENCE_BRANCH foreign key (BARNCH_NUMBER)
      references BRANCH (BRANCH_NUMBER)on delete cascade on update cascade
go

alter table LOAN
   add constraint FK_LOAN_REFERENCE_LOANACCO foreign key (ACCOUNTID)
      references LOANACCOUNT (ACCOUNTID)on delete cascade on update cascade
go

alter table LOAN
   add constraint FK_LOAN_REFERENCE_CUSTOMER foreign key (CUSTOMERID)
      references CUSTOMER (CUSTOMERID)on delete cascade on update cascade
go

alter table LOAN
   add constraint FK_LOAN_REFERENCE_EMPLOYEE foreign key (EMP_SSN)
      references EMPLOYEE (EMPLOYEEID)
go

alter table LOANACCOUNT
   add constraint FK_LOANACCO_REFERENCE_ACCOUNT foreign key (ACCOUNTID)
      references ACCOUNT (ACCOUNTID)
go

alter table TRANSCATION
   add constraint FK_TRANSCAT_REFERENCE_ACCOUNT foreign key (ACCOUNTID)
      references ACCOUNT (ACCOUNTID)on delete cascade on update cascade
go

