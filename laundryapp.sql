-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 24, 2019 at 03:27 PM
-- Server version: 10.1.34-MariaDB
-- PHP Version: 7.1.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `laundryapp`
--

-- --------------------------------------------------------

--
-- Table structure for table `t_detailorder`
--

CREATE TABLE `t_detailorder` (
  `id` int(11) NOT NULL,
  `nota` varchar(10) NOT NULL,
  `nama_item` varchar(100) NOT NULL,
  `jumlah` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_detailorder`
--

INSERT INTO `t_detailorder` (`id`, `nota`, `nama_item`, `jumlah`) VALUES
(2, '00001', 'jaket', 5),
(3, '00002', 'baju', 4),
(4, '00002', 'jaket', 2),
(7, '00006', 'gamis', 4),
(9, '00010', 'tes10', 4),
(10, '00012', 'baju', 5),
(11, '00012', 'jaket', 2),
(12, '00013', 'baju', 2);

-- --------------------------------------------------------

--
-- Table structure for table `t_order`
--

CREATE TABLE `t_order` (
  `nota` varchar(10) NOT NULL,
  `nama_customer` varchar(100) NOT NULL,
  `tgl_terima` date NOT NULL,
  `berat` double NOT NULL,
  `jenis_layanan` varchar(50) NOT NULL,
  `harga` double NOT NULL,
  `progress` varchar(50) NOT NULL,
  `status` varchar(50) NOT NULL,
  `tgl_diambil` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_order`
--

INSERT INTO `t_order` (`nota`, `nama_customer`, `tgl_terima`, `berat`, `jenis_layanan`, `harga`, `progress`, `status`, `tgl_diambil`) VALUES
('00001', 'tes', '2019-02-24', 4, 'Standard', 20000, 'Diterima', 'Sudah Dibayar', '2019-02-26'),
('00002', 'tes2', '2019-02-24', 4, 'Standard', 20000, 'Diterima', 'Sudah Dibayar', '2019-02-24'),
('00003', 'tes3', '2019-02-24', 4, 'Standard', 20000, 'Diterima', 'Sudah Dibayar', '2019-02-24'),
('00004', 'tes 43', '2019-02-23', 3, 'Standard', 15000, 'Diterima', 'Sudah Dibayar', '2019-02-24'),
('00006', 'hnfkh', '2019-02-24', 5, 'Standard', 25000, 'Diterima', 'Sudah Dibayar', '2019-02-24'),
('00007', 'tes', '2019-02-24', 4, 'Standard', 20000, 'Diterima', 'Sudah Dibayar', '2019-02-24'),
('00009', 'tw', '2019-02-24', 3, 'Standard', 15000, 'Diterima', 'Sudah Dibayar', '2019-03-05'),
('00010', 'tes10', '2019-02-24', 2, 'Standard', 10000, 'Diterima', 'Sudah Dibayar', '2019-03-08'),
('00011', 'tes11', '2019-02-24', 2, 'Standard', 10000, 'Diterima', 'Sudah Dibayar', '2019-02-24'),
('00012', 'rahmat', '2019-02-24', 5, 'Standard', 25000, 'Diterima', 'Sudah Dibayar', '2019-02-24'),
('00013', 'rahamt2', '2019-02-24', 4, 'Standard', 20000, 'Diterima', 'Sudah Dibayar', '2019-02-24');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `t_detailorder`
--
ALTER TABLE `t_detailorder`
  ADD PRIMARY KEY (`id`),
  ADD KEY `nota` (`nota`);

--
-- Indexes for table `t_order`
--
ALTER TABLE `t_order`
  ADD PRIMARY KEY (`nota`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `t_detailorder`
--
ALTER TABLE `t_detailorder`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `t_detailorder`
--
ALTER TABLE `t_detailorder`
  ADD CONSTRAINT `t_detailorder_ibfk_1` FOREIGN KEY (`nota`) REFERENCES `t_order` (`nota`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
