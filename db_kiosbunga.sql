-- phpMyAdmin SQL Dump
-- version 4.0.4.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 20, 2013 at 12:38 AM
-- Server version: 5.5.32
-- PHP Version: 5.4.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `db_kiosbunga`
--
CREATE DATABASE IF NOT EXISTS `db_kiosbunga` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `db_kiosbunga`;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_header`
--

CREATE TABLE IF NOT EXISTS `tbl_header` (
  `id_pesanan` int(11) NOT NULL,
  `nama_karyawan` varchar(20) NOT NULL,
  `tanggal` date NOT NULL,
  PRIMARY KEY (`id_pesanan`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tbl_header`
--

INSERT INTO `tbl_header` (`id_pesanan`, `nama_karyawan`, `tanggal`) VALUES
(1, 'anton', '2013-11-18'),
(2, 'anton', '2013-11-18'),
(3, 'anton', '2013-11-18'),
(4, 'anton', '2013-11-18'),
(5, 'anton', '2013-11-19'),
(6, 'anton', '2013-11-19'),
(7, 'anton', '2013-11-22'),
(8, 'anton', '2013-11-22');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_header_detail`
--

CREATE TABLE IF NOT EXISTS `tbl_header_detail` (
  `id_pesanan` int(11) NOT NULL,
  `nama_bunga` varchar(20) NOT NULL,
  `harga` int(7) NOT NULL,
  `qty` int(4) NOT NULL,
  `tanggal` date NOT NULL,
  `nama_pembeli` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tbl_header_detail`
--

INSERT INTO `tbl_header_detail` (`id_pesanan`, `nama_bunga`, `harga`, `qty`, `tanggal`, `nama_pembeli`) VALUES
(1, 'Melati', 20000, 1, '2013-11-18', 'masimin'),
(1, 'kertas', 35000, 2, '2013-11-18', 'masimin'),
(1, 'anggrek merah', 55000, 40, '2013-11-18', 'masimin'),
(2, 'kertas', 35000, 2, '2013-11-18', 'nima'),
(3, 'anggrek merah', 55000, 38, '2013-11-18', 'taara'),
(4, 'Melati', 20000, 2, '2013-11-18', 'ser'),
(4, 'kertas', 35000, 3, '2013-11-18', 'ser'),
(5, 'kertas', 35000, 4, '2013-11-19', 'ndaru'),
(5, 'Melati', 20000, 4, '2013-11-19', 'ndaru'),
(6, 'anggrek merah', 55000, 5, '2013-11-19', 'nami'),
(6, 'kamboja', 50000, 6, '2013-11-19', 'nami'),
(7, 'Melati', 20000, 4, '2013-11-22', 'amin'),
(7, 'anggrek merah', 55000, 7, '2013-11-22', 'amin'),
(8, 'kamboja', 50000, 6, '2013-11-22', 'asdff');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pelanggan`
--

CREATE TABLE IF NOT EXISTS `tbl_pelanggan` (
  `id_pelanggan` int(11) NOT NULL AUTO_INCREMENT,
  `nama_pelanggan` varchar(20) NOT NULL,
  `alamat` text NOT NULL,
  `no_hp` varchar(14) NOT NULL,
  PRIMARY KEY (`id_pelanggan`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=7 ;

--
-- Dumping data for table `tbl_pelanggan`
--

INSERT INTO `tbl_pelanggan` (`id_pelanggan`, `nama_pelanggan`, `alamat`, `no_hp`) VALUES
(1, 'ega', 'afafkajki', '+627582739529'),
(2, 'gandi', 'gentengt', '+6232235763567'),
(3, 'ndaru', 'muncar', '+6287857358494'),
(4, 'donita', 'stikom', '+6298832938924'),
(5, 'dani', 'tukang kayu', '+629765778'),
(6, 'rtw', '53453453', '+624343');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_stok`
--

CREATE TABLE IF NOT EXISTS `tbl_stok` (
  `id_bunga` int(11) NOT NULL AUTO_INCREMENT,
  `nama_bunga` varchar(20) NOT NULL,
  `jumlah` int(4) NOT NULL,
  `harga_pokok` int(7) NOT NULL,
  `harga_jual` int(7) NOT NULL,
  PRIMARY KEY (`id_bunga`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=8 ;

--
-- Dumping data for table `tbl_stok`
--

INSERT INTO `tbl_stok` (`id_bunga`, `nama_bunga`, `jumlah`, `harga_pokok`, `harga_jual`) VALUES
(1, 'Melati', 0, 15000, 20000),
(2, 'kertas', 8, 30000, 35000),
(3, 'anggrek merah', 18, 50000, 55000),
(4, 'kamboja', 28, 25000, 50000),
(5, 'Asoka', 32, 40000, 50000),
(6, 'jambu', 5, 30000, 40000),
(7, 'naga', 9, 6000, 8000);

-- --------------------------------------------------------

--
-- Table structure for table `user_login`
--

CREATE TABLE IF NOT EXISTS `user_login` (
  `id_user` int(11) NOT NULL,
  `user` varchar(20) NOT NULL,
  `pwd` text NOT NULL,
  `status` varchar(20) NOT NULL,
  `no_hp` varchar(14) NOT NULL,
  `nama` varchar(20) NOT NULL,
  PRIMARY KEY (`id_user`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `user_login`
--

INSERT INTO `user_login` (`id_user`, `user`, `pwd`, `status`, `no_hp`, `nama`) VALUES
(1, 'ac', 'e2075474294983e013ee4dd2201c7a73', 'Administrator', '+62345678912', 'budi'),
(2, 'a', '0cc175b9c0f1b6a831c399e269772661', 'Administrator', '+6209098978979', 'andi3'),
(3, 'kw', '048685d96262085442a1d5bb4a14bc3b', 'Karyawan', '+6249238429', 'anton');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
