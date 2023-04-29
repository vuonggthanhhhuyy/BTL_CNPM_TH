create database SmartTicketingSystem
go
use SmartTicketingSystem
go

create table MenuDataTable
(
	ticketID varchar(8) not null,
	ticketPicture varchar(100) not null,
    ticketName nvarchar(50) not null,
    ticketDescription nvarchar(500) not null,
    ticketQuantity int not null default 0,
    primary key(ticketID)
)
go

create procedure ProcMenuData
	@ticketPicture varchar(100),
    @ticketName nvarchar(50),
    @ticketDescription nvarchar(500),
    @ticketQuantity int
as
begin
    declare @ticketID varchar(8) = '';
    declare @alphabet varchar(62) = 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789';
	
    while len(@ticketID) < 8
    begin
        set @ticketID = @ticketID + substring(@alphabet, cast(rand() * len(@alphabet) as int), 1);
		if (select count(*) from MenuDataTable where ticketID = @ticketID) != 0
			set @ticketID = '';
    end;

    insert into MenuDataTable
    values (@ticketID, @ticketPicture, @ticketName, @ticketDescription, @ticketQuantity);
end;
go

exec ProcMenuData 'https://phugiabooking.vn/vnt_upload/weblink/logo_01.jpg', N'Jetstar', N'Hãng bay 5 sao', 10
exec ProcMenuData 'https://phugiabooking.vn/vnt_upload/weblink/logo_02.jpg', N'Vietjet Air', N'Hãng bay 4 sao', 15
exec ProcMenuData 'https://phugiabooking.vn/vnt_upload/weblink/logo_03.jpg', N'Vietnam Airlines', N'Hãng bay 3 sao', 13
exec ProcMenuData 'https://phugiabooking.vn/vnt_upload/weblink/logo_04.jpg', N'Singapore Airlines', N'Hãng bay 2 sao', 35
exec ProcMenuData 'https://phugiabooking.vn/vnt_upload/weblink/logo_05.jpg', N'Malaysia Airlines', N'Hãng bay 1 sao', 105
exec ProcMenuData 'https://phugiabooking.vn/vnt_upload/weblink/logo_06.jpg', N'Thai Smooth', N'Hãng bay 5 sao', 6
go

select * from MenuDataTable
go