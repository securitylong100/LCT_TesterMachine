CREATE TABLE IF NOT EXISTS m_orderid
(
ID int IDENTITY(1,1) NOT NULL,
orderid VARCHAR(256)  not NULL,
ck_model VARCHAR(256)  not NULL,
primary key (orderid)
)