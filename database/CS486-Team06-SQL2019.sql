/*
use master
go
drop database CS486_Team06_DB
*/

create database CS486_Team06_DB
go
use CS486_Team06_DB
go

create table Trainer(
	id int,
	name nvarchar(50) unique not null,
	
	primary key (id)
)

go

create table Contestant(
	id int,
	name nvarchar(50) not null,
	trainerID int foreign key references Trainer(id),

	primary key (id)
)

go

create table Performance(
	id int,
	contestantID int foreign key references Contestant(id) unique not null,
	usedSong nvarchar(50) not null,
	time time,
	selectedTeam int foreign key references Trainer(id),

	primary key (id)
)

go

create table TrainerFeedback(
	performanceID int foreign key references Performance(id),
	trainerID int foreign key references Trainer(id),
	content nvarchar(100),
	doSelect bit default 0 not null,

	primary key (performanceID, trainerID)
)

go

create trigger tg_numberOfTrainer
on Trainer
for insert
as
begin
	if (4 < (select count(*) from Trainer))
	begin
		raiserror('The maximum number of trainers is 4!', 16, 1)
		rollback
	end
end

go

insert into Trainer(id , name )
values  (1,N'Tuấn Hưng'),
        (2,N'Tuấn Ngọc'),
        (3,N'Thanh Hà'),
        (4,N'Hồ Hoài Anh');
go
insert into Contestant(id , name, trainerID)
values  (1,N'Bùi Anh Tuấn',Null),
        (2,N'Hoàng Đức Thịnh',Null),
        (3,N'Đỗ Hoài Nam',Null),
        (4,N'Đinh Bảo Yến',Null),
        (5,N'Trần Duy Đạt',Null),
        (6,N'Vũ Đức THịnh',Null),
        (7,N'Nguyễn Tùng Hiếu',Null),
        (8,N'Nguyễn Ngọc Lượng',Null),
        (9,N'Nguyễn Khánh Linh',Null),
        (10,N'Kiều Phan Quốc Lân',Null),
        (11,N'Nguyễn Cát Tiên',Null),
        (12,N'Nguyễn Thành Long',Null);
go
insert into Performance(id , contestantID , usedSong , time , selectedTeam )
values (1,1,N'When I was your man','00:04:00',null),
        (2,2,N'Perfect','00:03:55',null),
        (3,3,N'Cần Lắm','00:03:30',null),
        (4,4,N'Em ngày xưa khác rồi','00:03:10',null),
        (5,5,N'Năm ấy','00:02:57',null),
        (6,6,N'Em ơi','00:03:20',null),
        (7,7,N'Đừng xin lỗi nữa','00:03:37',null),
        (8,8,N'Một Đêm Say','00:03:00',null),
        (9,9,N'Mượn rượu tỏ tình','00:02:56',null),
        (10,10,N'Im in Love','00:03:40',null),
        (11,11,N'Flashlight','00:02:54',null),
        (12,12,N'Gốc ban công','00:03:10',null);
go


---- Phần dưới là để test thôi chứ chạy thử thì phải tự add feedback vô
insert into TrainerFeedback(performanceID , trainerID, content)
values  (1,1,N'Amazing Goodjob em'),
        (1,2,N'Really excellent performance! ' ),
        (1,3,N'Bạn thật tuyệt vời! Màn trình diễn này cho thấy nhiều tài năng của bạn' ),
        (1,4,N'Thật là một màn trình diễn tuyệt vời!' ),
        (2,1,N'Amazing Goodjob em' ),
        (2,2,N'Really excellent performance! ' ),
        (2,3,N'Bạn thật tuyệt vời! Màn trình diễn này cho thấy nhiều tài năng của bạn' ),
        (2,4,N'Thật là một màn trình diễn tuyệt vời!' ),
        (3,1,N'Amazing Goodjob em' ),
        (3,2,N'Really excellent performance! ' ),
        (3,3,N'Bạn thật tuyệt vời! Màn trình diễn này cho thấy nhiều tài năng của bạn' ),
        (3,4,N'Thật là một màn trình diễn tuyệt vời!' ),
        (4,1,N'Amazing Goodjob em' ),
        (4,2,N'Really excellent performance! ' ),
        (4,3,N'Bạn thật tuyệt vời! Màn trình diễn này cho thấy nhiều tài năng của bạn' ),
        (4,4,N'Thật là một màn trình diễn tuyệt vời!' ),
        (5,1,N'Amazing Goodjob em' ),
        (5,2,N'Really excellent performance! ' ),
        (5,3,N'Bạn thật tuyệt vời! Màn trình diễn này cho thấy nhiều tài năng của bạn' ),
        (5,4,N'Thật là một màn trình diễn tuyệt vời!' ),
        (6,1,N'Amazing Goodjob em' ),
        (6,2,N'Really excellent performance! ' ),
        (6,3,N'Bạn thật tuyệt vời! Màn trình diễn này cho thấy nhiều tài năng của bạn' ),
        (6,4,N'Thật là một màn trình diễn tuyệt vời!' ),
        (7,1,N'Amazing Goodjob em' ),
        (7,2,N'Really excellent performance! ' ),
        (7,3,N'Bạn thật tuyệt vời! Màn trình diễn này cho thấy nhiều tài năng của bạn' ),
        (7,4,N'Thật là một màn trình diễn tuyệt vời!' ),
        (8,1,N'Amazing Goodjob em' ),
        (8,2,N'Really excellent performance! ' ),
        (8,3,N'Bạn thật tuyệt vời! Màn trình diễn này cho thấy nhiều tài năng của bạn' ),
        (8,4,N'Thật là một màn trình diễn tuyệt vời!' ),
        (9,1,N'Amazing Goodjob em' ),
        (9,2,N'Really excellent performance! ' ),
        (9,3,N'Bạn thật tuyệt vời! Màn trình diễn này cho thấy nhiều tài năng của bạn' ),
        (9,4,N'Thật là một màn trình diễn tuyệt vời!' ),
        (10,1,N'Amazing Goodjob em' ),
        (10,2,N'Really excellent performance! ' ),
        (10,3,N'Bạn thật tuyệt vời! Màn trình diễn này cho thấy nhiều tài năng của bạn' ),
        (10,4,N'Thật là một màn trình diễn tuyệt vời!' ),
        (11,1,N'Amazing Goodjob em' ),
        (11,2,N'Really excellent performance! ' ),
        (11,3,N'Bạn thật tuyệt vời! Màn trình diễn này cho thấy nhiều tài năng của bạn' ),
        (11,4,N'Thật là một màn trình diễn tuyệt vời!' ),
        (12,1,N'Amazing Goodjob em' ),
        (12,2,N'Really excellent performance! ' ),
        (12,3,N'Bạn thật tuyệt vời! Màn trình diễn này cho thấy nhiều tài năng của bạn' ),
        (12,4,N'Thật là một màn trình diễn tuyệt vời!' );
 
 go

create function fn_getContestantsByTrainer(@id int)
returns table
    return (
        select con.id as CONTESTANT_ID, con.name as CONTESTANT_NAME
        from Contestant con join Trainer tra on con.trainerID = tra.id
        where tra.id = @id
    )
go

create function fn_getAllContestants()
returns table 
    return (
        select id as CONTESTANT_ID, name as CONTESTANT_NAME
        from Contestant
    )
go

create function fn_getAllTrainers()
returns table
    return (
        select id as TRAINER_ID, name as TRAINER_NAME
        from Trainer
    )
go

create function fn_getAllPerFormances()
returns table
    return (
        select pe.id as PERFORMANCE_ID, con.name + ', ' + pe.usedSong as PERFORMANCE_INFO 
        from Performance pe join Contestant con on pe.contestantID = con.id
    )
go

create procedure sp_addContestant
(@contestantID int, 
@contestantName nvarchar(50))
as 
begin
    insert into Contestant
    values (@contestantID, @contestantName, NULL)
end

go

create procedure sp_addPerformance
(@contestantName nvarchar(50),
@usedSong nvarchar(50),
@time time)
as 
begin transaction
set transaction isolation level serializable 
begin try
    declare @idc int
    declare @idp int

    set @idc = (select max(id) from Contestant)
    set @idc = @idc + 1
    exec sp_addContestant @idc, @contestantName;

    set @idp = (select max(id) from Performance)
    set @idp = @idp + 1
    
    insert into Performance
    values 
    (@idp, @idc, @usedSong, @time, NULL)

commit transaction;
end try
begin catch
    rollback transaction;
    throw 50000, 'Error while adding performance', 1;
end catch

go

create procedure sp_chooseTrainer
(@trainerID int, @performanceID int)
as 
begin transaction
set transaction isolation level serializable 
begin try
    if (not exists
        (select * from Trainer where id = @trainerID))
        throw 50000, 'Error while adding trainer for contestant', 1;
    if (not exists
        (select * from Performance where id = @performanceID))
        throw 50000, 'Error while adding trainer for contestant', 1;
    else
        begin
        declare @contestantID int
        set @contestantID = (select contestantID from Performance where id = @performanceID)
        update Contestant set trainerID = @trainerID where id = @contestantID
        update Performance set selectedTeam = @trainerID where id = @performanceID
        end
commit transaction;
end try
begin catch
    rollback transaction;
    throw;
end catch

go

create procedure sp_addTrainer(@Trainername nvarchar(50))
as
begin transaction
set transaction isolation level serializable 
begin try
    declare @id int
    set @id = (select max(id) from Trainer)
    set @id = @id + 1
    if not exists (select name from Trainer where name= @Trainername)
    begin 
        insert into Trainer
        values (@id, @Trainername)
    end
commit transaction;
end try
begin catch
    rollback transaction;
    throw 50000, 'Error while adding trainer', 1;
end catch

go

create procedure sp_addFeedback(@performanceID int, @trainerID int, @content nvarchar(100), @doSelect bit)
as
begin transaction
begin try
    insert into TrainerFeedback
    values (@performanceID, @trainerID, @content, @doSelect)
commit transaction;
end try
begin catch
    rollback transaction;
    throw 50000, 'Error while adding Feedback', 1;
end catch

delete from TrainerFeedback