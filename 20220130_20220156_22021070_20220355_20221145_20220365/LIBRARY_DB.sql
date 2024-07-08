﻿use LIBRARY_DB;

/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     5/8/2024 10:05:45 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ADMIN') and o.name = 'FK_ADMIN_TYPE2_USER')
alter table ADMIN
   drop constraint FK_ADMIN_TYPE2_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOK') and o.name = 'FK_BOOK_BELONG_TO_CATEGORY')
alter table BOOK
   drop constraint FK_BOOK_BELONG_TO_CATEGORY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOKCOPY') and o.name = 'FK_BOOKCOPY_HAS_BOOK')
alter table BOOKCOPY
   drop constraint FK_BOOKCOPY_HAS_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BORROW') and o.name = 'FK_BORROW_BORROW_STUDENT')
alter table BORROW
   drop constraint FK_BORROW_BORROW_STUDENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BORROW') and o.name = 'FK_BORROW_BORROW2_BOOK')
alter table BORROW
   drop constraint FK_BORROW_BORROW2_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MANAGE') and o.name = 'FK_MANAGE_MANAGE_ADMIN')
alter table MANAGE
   drop constraint FK_MANAGE_MANAGE_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MANAGE') and o.name = 'FK_MANAGE_MANAGE2_BOOK')
alter table MANAGE
   drop constraint FK_MANAGE_MANAGE2_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('STUDENT') and o.name = 'FK_STUDENT_TYPE_USER')
alter table STUDENT
   drop constraint FK_STUDENT_TYPE_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('WRITTEN_BY') and o.name = 'FK_WRITTEN__WRITTEN_B_BOOK')
alter table WRITTEN_BY
   drop constraint FK_WRITTEN__WRITTEN_B_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('WRITTEN_BY') and o.name = 'FK_WRITTEN__WRITTEN_B_AUTHOR')
alter table WRITTEN_BY
   drop constraint FK_WRITTEN__WRITTEN_B_AUTHOR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AUTHOR')
            and   type = 'U')
   drop table AUTHOR
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOK')
            and   name  = 'BELONG_TO_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOK.BELONG_TO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOOK')
            and   type = 'U')
   drop table BOOK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOOKCOPY')
            and   type = 'U')
   drop table BOOKCOPY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BORROW')
            and   name  = 'BORROW2_FK'
            and   indid > 0
            and   indid < 255)
   drop index BORROW.BORROW2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BORROW')
            and   name  = 'BORROW_FK'
            and   indid > 0
            and   indid < 255)
   drop index BORROW.BORROW_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BORROW')
            and   type = 'U')
   drop table BORROW
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CATEGORY')
            and   type = 'U')
   drop table CATEGORY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MANAGE')
            and   name  = 'MANAGE2_FK'
            and   indid > 0
            and   indid < 255)
   drop index MANAGE.MANAGE2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MANAGE')
            and   name  = 'MANAGE_FK'
            and   indid > 0
            and   indid < 255)
   drop index MANAGE.MANAGE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MANAGE')
            and   type = 'U')
   drop table MANAGE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('STUDENT')
            and   type = 'U')
   drop table STUDENT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"USER"')
            and   type = 'U')
   drop table "USER"
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('WRITTEN_BY')
            and   name  = 'WRITTEN_BY2_FK'
            and   indid > 0
            and   indid < 255)
   drop index WRITTEN_BY.WRITTEN_BY2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('WRITTEN_BY')
            and   name  = 'WRITTEN_BY_FK'
            and   indid > 0
            and   indid < 255)
   drop index WRITTEN_BY.WRITTEN_BY_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('WRITTEN_BY')
            and   type = 'U')
   drop table WRITTEN_BY
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   USER_ID              int                 not null,
   is_admin             BIT                  not null, 
   EMAIL                varchar(40)          not null,
   USERNAME             varchar(15)          not null,
   PASSWORD             varchar(250)          not null,
   constraint PK_ADMIN primary key (USER_ID)
)
go

/*==============================================================*/
/* Table: AUTHOR                                                */
/*==============================================================*/
create table AUTHOR (
   AUTHOR_ID            int                  not null,
   AUTHOR_NAME          varchar(15)          not null,
   constraint PK_AUTHOR primary key (AUTHOR_ID)
)
go

/*==============================================================*/
/* Table: BOOK                                                  */
/*==============================================================*/
create table BOOK (
   ISBN                 bigint               not null,
   CATEGORY_ID          int                  null,
   PUBLISHING_DATE      datetime             not null,
   TITLE                varchar(25)          not null,
   PRICE                money                not null,
   PUBLISHER            varchar(25)          not null,
   constraint PK_BOOK primary key (ISBN)
)
go

/*==============================================================*/
/* Index: BELONG_TO_FK                                          */
/*==============================================================*/



create nonclustered index BELONG_TO_FK on BOOK (CATEGORY_ID ASC)
go

/*==============================================================*/
/* Table: BOOKCOPY                                              */
/*==============================================================*/
create table BOOKCOPY (
   ISBN                 bigint               not null,
   Copy_Id              bigint               not null,
   NUM_OF_COPIES        int                  not null,
   constraint PK_BOOKCOPY primary key (Copy_Id,ISBN)
)
go

/*==============================================================*/
/* Table: BORROW                                                */
/*==============================================================*/
create table BORROW (
   USER_ID              int                  not null,
   ISBN                 bigint               not null,
   Copy_Id              bigint               not null,
   constraint PK_BORROW primary key (USER_ID, Copy_Id)
)
go

/*==============================================================*/
/* Index: BORROW_FK                                             */
/*==============================================================*/



create nonclustered index BORROW_FK on BORROW (USER_ID ASC)
go

/*==============================================================*/
/* Index: BORROW2_FK                                            */
/*==============================================================*/



create nonclustered index BORROW2_FK on BORROW (Copy_Id ASC)
go

/*==============================================================*/
/* Table: CATEGORY                                              */
/*==============================================================*/
create table CATEGORY (
   CATEGORY_NAME        varchar(15)          not null,
   CATEGORY_ID          int                  not null,
   constraint PK_CATEGORY primary key (CATEGORY_ID)
)
go

/*==============================================================*/
/* Table: MANAGE                                                */
/*==============================================================*/
create table MANAGE (
   USER_ID              int                  not null,
   ISBN                 bigint               not null,
   constraint PK_MANAGE primary key (USER_ID, ISBN)
)
go

/*==============================================================*/
/* Index: MANAGE_FK                                             */
/*==============================================================*/



create nonclustered index MANAGE_FK on MANAGE (USER_ID ASC)
go

/*==============================================================*/
/* Index: MANAGE2_FK                                            */
/*==============================================================*/



create nonclustered index MANAGE2_FK on MANAGE (ISBN ASC)
go

/*==============================================================*/
/* Table: STUDENT                                               */
/*==============================================================*/
create table STUDENT (
   USER_ID              int                  not null,
   is_admin             BIT                  not null,
   EMAIL                varchar(40)          not null,
   USERNAME             varchar(15)          not null,
   PASSWORD             varchar(250)          not null,
   constraint PK_STUDENT primary key (USER_ID)
)
go

/*==============================================================*/
/* Table: "USER"                                                */
/*==============================================================*/
create table "USER" (
   EMAIL                varchar(40)          not null,
   USER_ID              int                  IDENTITY(1, 1),
   is_admin             BIT                  not null,
   USERNAME             varchar(15)          not null,
   PASSWORD             varchar(250)          not null,
   constraint PK_USER primary key (USER_ID)
)
go

/*==============================================================*/
/* Table: WRITTEN_BY                                            */
/*==============================================================*/
create table WRITTEN_BY (
   ISBN                 bigint               not null,
   AUTHOR_ID            int                  not null,
   constraint PK_WRITTEN_BY primary key (ISBN, AUTHOR_ID)
)
go

/*==============================================================*/
/* Index: WRITTEN_BY_FK                                         */
/*==============================================================*/




create nonclustered index WRITTEN_BY_FK on WRITTEN_BY (ISBN ASC)
go

/*==============================================================*/
/* Index: WRITTEN_BY2_FK                                        */
/*==============================================================*/




create nonclustered index WRITTEN_BY2_FK on WRITTEN_BY (AUTHOR_ID ASC)
go

alter table ADMIN
   add constraint FK_ADMIN_TYPE2_USER foreign key (USER_ID)
      references "USER" (USER_ID)
go

alter table BOOK
   add constraint FK_BOOK_BELONG_TO_CATEGORY foreign key (CATEGORY_ID)
      references CATEGORY (CATEGORY_ID)
go

alter table BOOKCOPY
   add constraint FK_BOOKCOPY_HAS_BOOK foreign key (ISBN)
      references BOOK (ISBN)
go

alter table BORROW
   add constraint FK_BORROW_BORROW_STUDENT foreign key (USER_ID)
      references STUDENT (USER_ID)
go

alter table BORROW
   add constraint FK_BORROW_BORROW2_BOOK foreign key (Copy_Id,ISBN)
      references BOOKCOPY (Copy_Id,ISBN)
go

alter table MANAGE
   add constraint FK_MANAGE_MANAGE_ADMIN foreign key (USER_ID)
      references ADMIN (USER_ID)
go

alter table MANAGE
   add constraint FK_MANAGE_MANAGE2_BOOK foreign key (ISBN)
      references BOOK (ISBN)
go

alter table STUDENT
   add constraint FK_STUDENT_TYPE_USER foreign key (USER_ID)
      references "USER" (USER_ID)
go

alter table WRITTEN_BY
   add constraint FK_WRITTEN__WRITTEN_B_BOOK foreign key (ISBN)
      references BOOK (ISBN)
go

alter table WRITTEN_BY
   add constraint FK_WRITTEN__WRITTEN_B_AUTHOR foreign key (AUTHOR_ID)
      references AUTHOR (AUTHOR_ID)
go

