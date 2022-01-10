create trigger ad_asDd on dbo.Extradition
for insert 
as
declare @i_new INT;
Select @i_new = Publisher from inserted;
declare @num_new INT;
Select @num_new = num from inserted;
declare @num_pub INT;
Select @num_pub = num_cop from Publisher
where  dbo.Publisher.Id = @i_new;
if(@num_new>@num_pub)
Begin
Set nocount on;
rollback tran;
print 'Недостаточное количество экземпляров в наличии'
end;