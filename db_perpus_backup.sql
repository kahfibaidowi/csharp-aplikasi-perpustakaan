-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versi server:                 10.1.32-MariaDB - mariadb.org binary distribution
-- OS Server:                    Win32
-- HeidiSQL Versi:               9.5.0.5437
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- membuang struktur untuk table db_perpus.tb_buku
CREATE TABLE IF NOT EXISTS `tb_buku` (
  `id_buku` varchar(10) NOT NULL,
  `id_rak` varchar(6) NOT NULL,
  `judul` varchar(100) NOT NULL,
  `pengarang` varchar(50) NOT NULL,
  `penerbit` varchar(50) NOT NULL,
  `tahun` int(11) NOT NULL,
  `stok` int(11) NOT NULL,
  PRIMARY KEY (`id_buku`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Membuang data untuk tabel db_perpus.tb_buku: ~20 rows (lebih kurang)
/*!40000 ALTER TABLE `tb_buku` DISABLE KEYS */;
INSERT INTO `tb_buku` (`id_buku`, `id_rak`, `judul`, `pengarang`, `penerbit`, `tahun`, `stok`) VALUES
	('BK1', 'RK1', 'Trik rahasia master PHP dan MySQLI', 'lukmanul hakim', 'lokomedia', 2014, 3),
	('BK10', 'RK3', 'Mengenal Raden Said alias Sunan Kalijaga', 'M Naufal Fahlevi', 'andi offset', 2010, 2),
	('BK12', 'RK1', 'Mahir Bahasa Pemrograman PHP dalam 10 hari', 'Kahfi Baidowi', 'Lokomedia', 2017, 1),
	('BK13', 'RK4', 'Bagai Langit dan Bumi', 'farida nur aly', 'lokomedia', 2010, 2),
	('BK14', 'RK1', 'Trik Rahasia Menjadi Master Wordpress Handal', 'Rohi Abdullah', 'Asfa Media', 2015, 5),
	('BK16', 'RK4', 'Naruto Shippuden episode 495', 'Yuhiwo Miteiruka', 'Hancong Japan', 2016, 2),
	('BK17', 'RK1', 'Belajar Pemrograman Web dengan JSP untuk Pemula', 'Kahfi Baidowi', 'Maxicom', 2016, 5),
	('BK18', 'RK1', 'Tutorial Masak Sayur Bayam untuk Kraby Patty', 'Aldo Yusa', 'Media Kita', 2015, 1),
	('BK19', 'RK4', 'Rembulan Bersinar di Hari Minggu', 'Tere Liye', 'Gampang Media', 2014, 2),
	('BK2', 'RK4', 'Kancil nyolong timun', 'm hasan s j', 'media anak', 2008, 3),
	('BK20', 'RK4', 'Hafalan Sholat Delisa', 'Tere Liye', 'Media Novel', 2010, 1),
	('BK22', 'RK4', 'Negeri Para Bedebah', 'tere liye', 'Media Novel', 2018, 10),
	('BK23', 'RK4', 'Belajar Dari Air yang Mengalir', 'Kahfi Baidowi', 'Media Filsafat', 2010, 5),
	('BK24', 'RK1', 'Networking Academy', 'No Name', 'samata Publisher', 2019, 3),
	('BK3', 'RK1', 'Proyek website super wow dengan PHP dan JQuery', 'lukmanul hakim', 'lokomedia', 2012, 5),
	('BK4', 'RK2', 'From Zero to Hero', 'No Name', 'Media Islam', 2015, 2),
	('BK5', 'RK2', 'The way to win', 'no name', 'Media Islam', 2015, 2),
	('BK6', 'RK2', 'Mahir CSS3 & Bootstrap dalam 1 Minggu', 'kahfi baidowi', 'lokomedia', 2017, 3),
	('BK7', 'RK3', 'Sejarah Kerajaan Majapahit', 'kahfi baidowi', 'andi offset', 2010, 1),
	('BK8', 'RK2', 'Kumpulan hadits bukhari lengkap', 'faizal fakhri', 'Media islam', 2015, 5),
	('BK9', 'RK2', 'Fiqih sunnah untuk wanita', 'no name', 'Media Islam', 2015, 2);
/*!40000 ALTER TABLE `tb_buku` ENABLE KEYS */;

-- membuang struktur untuk table db_perpus.tb_detail_kembali
CREATE TABLE IF NOT EXISTS `tb_detail_kembali` (
  `id_pinjam` int(11) NOT NULL,
  `id_buku` varchar(10) NOT NULL,
  `tipe_denda` varchar(100) NOT NULL,
  `denda` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Membuang data untuk tabel db_perpus.tb_detail_kembali: ~9 rows (lebih kurang)
/*!40000 ALTER TABLE `tb_detail_kembali` DISABLE KEYS */;
INSERT INTO `tb_detail_kembali` (`id_pinjam`, `id_buku`, `tipe_denda`, `denda`) VALUES
	(1, 'BK1', '', 0),
	(1, 'BK22', 'buku hilang', 5000),
	(1, 'BK23', '', 0),
	(10, 'BK22', '', 0),
	(10, 'BK18', '', 0),
	(13, 'BK22', '', 0),
	(13, 'BK19', '', 0),
	(14, 'BK8', '', 0),
	(14, 'BK23', 'buku hilang', 45000);
/*!40000 ALTER TABLE `tb_detail_kembali` ENABLE KEYS */;

-- membuang struktur untuk table db_perpus.tb_detail_pinjam
CREATE TABLE IF NOT EXISTS `tb_detail_pinjam` (
  `id_pinjam` int(11) NOT NULL,
  `id_buku` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Membuang data untuk tabel db_perpus.tb_detail_pinjam: ~21 rows (lebih kurang)
/*!40000 ALTER TABLE `tb_detail_pinjam` DISABLE KEYS */;
INSERT INTO `tb_detail_pinjam` (`id_pinjam`, `id_buku`) VALUES
	(1, 'BK1'),
	(1, 'BK22'),
	(1, 'BK23'),
	(4, 'BK22'),
	(4, 'BK23'),
	(4, 'BK13'),
	(5, 'BK18'),
	(5, 'BK19'),
	(6, 'BK17'),
	(7, 'BK9'),
	(7, 'BK14'),
	(10, 'BK22'),
	(10, 'BK18'),
	(11, 'BK18'),
	(13, 'BK22'),
	(13, 'BK19'),
	(14, 'BK8'),
	(14, 'BK23'),
	(15, 'BK22'),
	(15, 'BK23'),
	(15, 'BK19'),
	(16, 'BK22'),
	(16, 'BK23');
/*!40000 ALTER TABLE `tb_detail_pinjam` ENABLE KEYS */;

-- membuang struktur untuk table db_perpus.tb_kembali
CREATE TABLE IF NOT EXISTS `tb_kembali` (
  `id_pinjam` int(11) NOT NULL,
  `id_pegawai` varchar(6) NOT NULL,
  `tgl_kembali` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Membuang data untuk tabel db_perpus.tb_kembali: ~2 rows (lebih kurang)
/*!40000 ALTER TABLE `tb_kembali` DISABLE KEYS */;
INSERT INTO `tb_kembali` (`id_pinjam`, `id_pegawai`, `tgl_kembali`) VALUES
	(1, '987654', '2019-01-01'),
	(10, '987654', '2019-01-01'),
	(13, '987654', '2019-01-01'),
	(14, '789011', '2019-01-03');
/*!40000 ALTER TABLE `tb_kembali` ENABLE KEYS */;

-- membuang struktur untuk table db_perpus.tb_member
CREATE TABLE IF NOT EXISTS `tb_member` (
  `id_member` varchar(6) NOT NULL,
  `nama_lengkap` varchar(50) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `no_telp` varchar(20) NOT NULL,
  `tgl_registrasi` date NOT NULL,
  `aktif` varchar(1) NOT NULL,
  PRIMARY KEY (`id_member`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Membuang data untuk tabel db_perpus.tb_member: ~9 rows (lebih kurang)
/*!40000 ALTER TABLE `tb_member` DISABLE KEYS */;
INSERT INTO `tb_member` (`id_member`, `nama_lengkap`, `alamat`, `no_telp`, `tgl_registrasi`, `aktif`) VALUES
	('1', 'Kahfi Baidowi', 'dk gebangarum ds plumpungrejo kec wonoasri madiun, kode pos 63157', '087889987675', '2018-12-01', 'y'),
	('10', 'Sarep', 'mboh', '90384', '2018-12-04', 'n'),
	('11', 'Iszul Iqbal Haironi', 'bekasi', '08987837486', '2018-12-08', 'y'),
	('2', 'Reza Aditya R', 'dk gebangarum rt 16 rw 03', '085678564786', '2018-12-01', 'y'),
	('3', 'Muhammad Hasan S J', 'pacitan', '08357826482', '2018-12-01', 'y'),
	('4', 'Muhammad Naufal F', 'indramayu', '0878978756', '2018-12-01', 'y'),
	('5', 'Laila Nurul Hidayah', 'dk pelem ds purwosari kec wonoasri madiun, kode pos 63157', '0878978756', '2018-12-01', 'y'),
	('6', 'Astri Kusuma Agustiyaningrum', 'dk pelem', '089674563', '2018-12-01', 'y'),
	('7', 'Fahrul Firmansyah', 'dsn gebangarum kec wonoasri madiun', '0989738783', '2018-12-03', 'y');
/*!40000 ALTER TABLE `tb_member` ENABLE KEYS */;

-- membuang struktur untuk table db_perpus.tb_pegawai
CREATE TABLE IF NOT EXISTS `tb_pegawai` (
  `id_pegawai` varchar(6) NOT NULL,
  `nama_lengkap` varchar(50) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `no_telp` varchar(20) NOT NULL,
  `passwd` varchar(50) NOT NULL,
  `jabatan` varchar(20) NOT NULL,
  `aktif` varchar(1) NOT NULL DEFAULT 'n',
  PRIMARY KEY (`id_pegawai`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Membuang data untuk tabel db_perpus.tb_pegawai: ~3 rows (lebih kurang)
/*!40000 ALTER TABLE `tb_pegawai` DISABLE KEYS */;
INSERT INTO `tb_pegawai` (`id_pegawai`, `nama_lengkap`, `alamat`, `no_telp`, `passwd`, `jabatan`, `aktif`) VALUES
	('000002', 'Muhammad hasan', 'jl kaliurang km 2 yogyakarta', '08978353278', 'fc3f318fba8b3c1502bece62a27712df', 'administrator', 'y'),
	('789011', 'Muhammad Naufal F', 'Indramayu', '0898378734', 'a7ef174d3ed272acd2b72913a7ef9d40', 'pelayanan', 'y'),
	('987654', 'kahfi baidowi', 'jl monginsidi no 10 kec mangunharjo kota madiun', '08978756485', '64d2753197ba92f6fe30371c52d1b824', 'katalog', 'y');
/*!40000 ALTER TABLE `tb_pegawai` ENABLE KEYS */;

-- membuang struktur untuk table db_perpus.tb_pengunjung
CREATE TABLE IF NOT EXISTS `tb_pengunjung` (
  `id_pengunjung` int(11) NOT NULL AUTO_INCREMENT,
  `member` varchar(1) NOT NULL,
  `id_member` varchar(6) NOT NULL,
  `nama_lengkap` varchar(50) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `tgl_berkunjung` date NOT NULL,
  PRIMARY KEY (`id_pengunjung`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

-- Membuang data untuk tabel db_perpus.tb_pengunjung: ~9 rows (lebih kurang)
/*!40000 ALTER TABLE `tb_pengunjung` DISABLE KEYS */;
INSERT INTO `tb_pengunjung` (`id_pengunjung`, `member`, `id_member`, `nama_lengkap`, `alamat`, `tgl_berkunjung`) VALUES
	(1, 'n', '', 'kahfi baidowi', 'bangarum', '2019-01-01'),
	(2, 'n', '', 'kahfi baidowi', 'bangarum', '2019-01-01'),
	(3, 'n', '', 'aric suprasetyo', 'sobrah', '2019-01-02'),
	(4, 'n', '', 'kahfi baidowi', 'bangarum', '2019-01-02'),
	(5, 'n', '', 'kahfi baidowi', 'bangarum', '2019-01-02'),
	(6, 'y', '1', '', '', '2019-01-03'),
	(8, 'n', '', 'reza aditya ramadhani', 'wonoasri', '2019-01-03'),
	(9, 'y', '5', '', '', '2019-01-03'),
	(10, 'y', '2', '', '', '2019-01-06');
/*!40000 ALTER TABLE `tb_pengunjung` ENABLE KEYS */;

-- membuang struktur untuk table db_perpus.tb_pinjam
CREATE TABLE IF NOT EXISTS `tb_pinjam` (
  `id_pinjam` int(11) NOT NULL AUTO_INCREMENT,
  `id_member` varchar(6) NOT NULL,
  `id_pegawai` varchar(6) NOT NULL,
  `tgl_pinjam` date NOT NULL,
  PRIMARY KEY (`id_pinjam`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

-- Membuang data untuk tabel db_perpus.tb_pinjam: ~8 rows (lebih kurang)
/*!40000 ALTER TABLE `tb_pinjam` DISABLE KEYS */;
INSERT INTO `tb_pinjam` (`id_pinjam`, `id_member`, `id_pegawai`, `tgl_pinjam`) VALUES
	(1, '2', '987654', '2019-01-01'),
	(4, '1', '987654', '2019-01-01'),
	(5, '5', '987654', '2019-01-01'),
	(6, '11', '987654', '2019-01-01'),
	(7, '6', '987654', '2019-01-01'),
	(10, '3', '987654', '2019-01-01'),
	(11, '3', '987654', '2019-01-01'),
	(13, '2', '987654', '2019-01-01'),
	(14, '2', '789011', '2019-01-03'),
	(15, '2', '789011', '2019-01-05'),
	(16, '7', '789011', '2019-01-06');
/*!40000 ALTER TABLE `tb_pinjam` ENABLE KEYS */;

-- membuang struktur untuk table db_perpus.tb_rak_buku
CREATE TABLE IF NOT EXISTS `tb_rak_buku` (
  `id_rak` varchar(6) NOT NULL,
  `nama_rak_buku` varchar(50) NOT NULL,
  PRIMARY KEY (`id_rak`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Membuang data untuk tabel db_perpus.tb_rak_buku: ~6 rows (lebih kurang)
/*!40000 ALTER TABLE `tb_rak_buku` DISABLE KEYS */;
INSERT INTO `tb_rak_buku` (`id_rak`, `nama_rak_buku`) VALUES
	('RK1', 'rak buku komputer'),
	('RK2', 'rak buku agama'),
	('RK3', 'rak buku sejarah'),
	('RK4', 'rak buku novel / fiksi'),
	('RK5', 'rak buku tutorial'),
	('RK6', 'rak buku filsafat');
/*!40000 ALTER TABLE `tb_rak_buku` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
