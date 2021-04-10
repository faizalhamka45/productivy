CREATE TABLE [dbo].[TabelKegiatan] (
    [jenis]              VARCHAR (20) NULL,
	[nama_kegiatan]		 VARCHAR (50) NULL,
    [tanggal_dikerjakan] DATE         NULL,
    [jam_mulai]          TIME (7)     NULL,
    [jam_berakhir]       TIME (7)     NULL,
    [skala_prioritas]    VARCHAR (10) NULL,
    [repeat]             VARCHAR (10) NULL,
    [sequence]           VARCHAR (30) NULL,
    [deskripsi]          VARCHAR (50) NULL
);

