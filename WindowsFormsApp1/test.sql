/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     5/5/2024 7:07:47 PM                          */
/*==============================================================*/


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
   where r.fkeyid = object_id('BRANCH_LOANS') and o.name = 'FK_BRANCH_L_REFERENCE_LOANS')
alter table BRANCH_LOANS
   drop constraint FK_BRANCH_L_REFERENCE_LOANS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DEPENDANT_ACCOUNT') and o.name = 'FK_DEPENDAN_REFERENCE_CUSTOMER')
alter table DEPENDANT_ACCOUNT
   drop constraint FK_DEPENDAN_REFERENCE_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLOYEE') and o.name = 'FK_EMPLOYEE_REFERENCE_BRANCH')
alter table EMPLOYEE
   drop constraint FK_EMPLOYEE_REFERENCE_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOANS') and o.name = 'FK_LOANS_REFERENCE_EMPLOYEE')
alter table LOANS
   drop constraint FK_LOANS_REFERENCE_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOANS') and o.name = 'FK_LOANS_REFERENCE_CUSTOMER')
alter table LOANS
   drop constraint FK_LOANS_REFERENCE_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRANSCATION') and o.name = 'FK_TRANSCAT_REFERENCE_CUSTOMER')
alter table TRANSCATION
   drop constraint FK_TRANSCAT_REFERENCE_CUSTOMER
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
           where  id = object_id('CUSTOMER')
            and   type = 'U')
   drop table CUSTOMER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DEPENDANT_ACCOUNT')
            and   type = 'U')
   drop table DEPENDANT_ACCOUNT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMPLOYEE')
            and   type = 'U')
   drop table EMPLOYEE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOANS')
            and   type = 'U')
   drop table LOANS
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
   ACCOUNT_NUMBER       numeric(24)          not null,
   CUST_SSN             numeric(15)          null,
   ACCOUNT_BALANCE      numeric(15)          not null,
   ACCOUNT_TYPE         varchar(10)          not null,
   constraint PK_ACCOUNT primary key (ACCOUNT_NUMBER)
)
go

/*==============================================================*/
/* Table: BANK                                                  */
/*==============================================================*/
create table BANK (
   CODE                 numeric(15)          not null,
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
   BARNCH_NUMBER        numeric(14)          not null,
   BANK_CODE            numeric(15)          null,
   BARNCH_ADDRESS       varchar(255)         not null,
   constraint PK_BRANCH primary key (BARNCH_NUMBER)
)
go

/*==============================================================*/
/* Table: BRANCH_CUSTOMER                                       */
/*==============================================================*/
create table BRANCH_CUSTOMER (
   BARNCH_NUMBER        numeric(14)          not null,
   CUST_SSN             numeric(15)          not null,
   constraint PK_BRANCH_CUSTOMER primary key (BARNCH_NUMBER, CUST_SSN)
)
go

/*==============================================================*/
/* Table: BRANCH_LOANS                                          */
/*==============================================================*/
create table BRANCH_LOANS (
   BARNCH_NUMBER        numeric(14)          not null,
   LOAN_NUMBER          numeric(10)          not null,
   constraint PK_BRANCH_LOANS primary key (BARNCH_NUMBER, LOAN_NUMBER)
)
go

/*==============================================================*/
/* Table: CUSTOMER                                              */
/*==============================================================*/
create table CUSTOMER (
   CUST_SSN             numeric(15)          not null,
   CUSTOMER_FNAME       varchar(10)          not null,
   CUSTOMER_LNAME       varchar(10)          not null,
   CUSTOMER_ADDRESS     varchar(255)         not null,
   CUST_PHONE           numeric(12)          not null,
   constraint PK_CUSTOMER primary key (CUST_SSN)
)
go

/*==============================================================*/
/* Table: DEPENDANT_ACCOUNT                                     */
/*==============================================================*/
create table DEPENDANT_ACCOUNT (
   DEPENDANT_FNAME      varchar(10)          not null,
   CUST_SSN             numeric(15)          not null,
   DEPENDANT_LNAME      varchar(10)          not null,
   DEPENDANT_BALANCE    numeric(15)          not null,
   constraint PK_DEPENDANT_ACCOUNT primary key (DEPENDANT_FNAME, CUST_SSN)
)
go

/*==============================================================*/
/* Table: EMPLOYEE                                              */
/*==============================================================*/
create table EMPLOYEE (
   EMP_SSN              numeric(15)          not null,
   BARNCH_NUMBER        numeric(14)          null,
   EMP_FNAME            varchar(10)          not null,
   EMP_LNAME            varchar(10)          not null,
   constraint PK_EMPLOYEE primary key (EMP_SSN)
)
go

/*==============================================================*/
/* Table: LOANS                                                 */
/*==============================================================*/
create table LOANS (
   LOAN_NUMBER          numeric(10)          not null,
   EMP_SSN              numeric(15)          null,
   CUST_SSN             numeric(15)          null,
   LOAN_TYPE            varchar(30)          not null,
   LOAN_AMOUNT          numeric(10)          not null,
   constraint PK_LOANS primary key (LOAN_NUMBER)
)
go

/*==============================================================*/
/* Table: TRANSCATION                                           */
/*==============================================================*/
create table TRANSCATION (
   CUST_SSN             numeric(15)          not null,
   TRANSACTION_DATE     timestamp            not null,
   TRANSACTION_AMOUNT   numeric(15)          not null,
   TRANSACTION_TYPE     varchar(10)          not null,
   constraint PK_TRANSCATION primary key (CUST_SSN, TRANSACTION_DATE)
)
go

alter table ACCOUNT
   add constraint FK_ACCOUNT_REFERENCE_CUSTOMER foreign key (CUST_SSN)
      references CUSTOMER (CUST_SSN)
go

alter table BANK_ADDRESSES
   add constraint FK_BANK_ADD_REFERENCE_BANK foreign key (BANK_CODE)
      references BANK (CODE)
go

alter table BRANCH
   add constraint FK_BRANCH_REFERENCE_BANK foreign key (BANK_CODE)
      references BANK (CODE)
go

alter table BRANCH_CUSTOMER
   add constraint FK_BRANCH_C_REFERENCE_CUSTOMER foreign key (CUST_SSN)
      references CUSTOMER (CUST_SSN)
go

alter table BRANCH_CUSTOMER
   add constraint FK_BRANCH_C_REFERENCE_BRANCH foreign key (BARNCH_NUMBER)
      references BRANCH (BARNCH_NUMBER)
go

alter table BRANCH_LOANS
   add constraint FK_BRANCH_L_REFERENCE_BRANCH foreign key (BARNCH_NUMBER)
      references BRANCH (BARNCH_NUMBER)
go

alter table BRANCH_LOANS
   add constraint FK_BRANCH_L_REFERENCE_LOANS foreign key (LOAN_NUMBER)
      references LOANS (LOAN_NUMBER)
go

alter table DEPENDANT_ACCOUNT
   add constraint FK_DEPENDAN_REFERENCE_CUSTOMER foreign key (CUST_SSN)
      references CUSTOMER (CUST_SSN)
go

alter table EMPLOYEE
   add constraint FK_EMPLOYEE_REFERENCE_BRANCH foreign key (BARNCH_NUMBER)
      references BRANCH (BARNCH_NUMBER)
go

alter table LOANS
   add constraint FK_LOANS_REFERENCE_EMPLOYEE foreign key (EMP_SSN)
      references EMPLOYEE (EMP_SSN)
go

alter table LOANS
   add constraint FK_LOANS_REFERENCE_CUSTOMER foreign key (CUST_SSN)
      references CUSTOMER (CUST_SSN)
go

alter table TRANSCATION
   add constraint FK_TRANSCAT_REFERENCE_CUSTOMER foreign key (CUST_SSN)
      references CUSTOMER (CUST_SSN)
go

