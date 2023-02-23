CREATE TABLE IF NOT EXISTS m_ck_point
(
ID int IDENTITY(1,1) NOT NULL,
ck_serial int  DEFAULT 1,
ck_Max_Noloadlimitspeed  int DEFAULT 3600,
ck_Min_Noloadlimitspeed int DEFAULT 2900,
ck_Steppower FLOAT DEFAULT 0,
ck_power FLOAT DEFAULT 0,
ck_Steppercentage int DEFAULT 0,
ck_Max_Generator int  DEFAULT 100,
ck_Min_Generator int DEFAULT 0,
ck_Max_VolGenerator int DEFAULT 240,
ck_Min_VolGenerator int DEFAULT 0,
ck_Max_frequency FLOAT DEFAULT 60,
ck_Min_frequency FLOAT DEFAULT 0,
ck_Max_braketime FLOAT DEFAULT 5,
ck_Min_braketime FLOAT DEFAULT 0,
ck_Max_regulationspeed FLOAT DEFAULT 10,
ck_Min_regulationSpeed FLOAT DEFAULT -10,
ck_Max_fluctuationspeed FLOAT DEFAULT 10,
ck_Min_fluctuationspeed FLOAT DEFAULT -10,
ck_LoadTime int DEFAULT 4,
ck_speed int DEFAULT 3600,
ck_cycles  int DEFAULT 1,
ck_model VARCHAR(256) ,
ck_testbrakes  VARCHAR(64) DEFAULT 'NO',
primary key (ck_serial ,ck_model)
)