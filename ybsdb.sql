-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 05 Haz 2021, 11:50:19
-- Sunucu sürümü: 10.4.17-MariaDB
-- PHP Sürümü: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `ybsdb`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `gecmis`
--

CREATE TABLE `gecmis` (
  `gecmisId` int(11) NOT NULL,
  `ad` text COLLATE utf8_turkish_ci NOT NULL,
  `soyad` text COLLATE utf8_turkish_ci NOT NULL,
  `aciklama` text COLLATE utf8_turkish_ci NOT NULL,
  `borc` double NOT NULL,
  `tarih` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `gecmis`
--

INSERT INTO `gecmis` (`gecmisId`, `ad`, `soyad`, `aciklama`, `borc`, `tarih`) VALUES
(35, 'FAİK', 'AHMET', 'Koli Sabun 30', 365, '2021-05-21'),
(36, 'FAİK', 'AHMET', 'Koli Sabun 30', 415, '2021-05-21'),
(38, 'FAİK', 'AHMET', 'Koli Sabun 30', 437, '2021-05-21'),
(39, 'FAİK', 'AHMET', 'Koli Sabun 30', 414, '2021-05-21'),
(40, 'HALİL', 'ÖZTÜRK', '10m kum, 3000 Adet Tuğla', 25500, '2021-05-21'),
(41, 'MUSTAFA', 'ERTAŞ', '20 koli su, 25 koli meyve suyu', 1020, '2021-06-05'),
(42, 'MUSTAFA', 'ERTAŞ', '20 koli su, 25 koli meyve suyu', 770, '2021-05-21'),
(43, 'HALİL', 'ÖZTÜRK', '10m kum, 3000 Adet Tuğla', 5500, '2021-05-21');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `musteri`
--

CREATE TABLE `musteri` (
  `musteriId` int(11) NOT NULL,
  `ad` text COLLATE utf8_turkish_ci NOT NULL,
  `soyad` text COLLATE utf8_turkish_ci NOT NULL,
  `telefon` text COLLATE utf8_turkish_ci NOT NULL,
  `adres` text COLLATE utf8_turkish_ci NOT NULL,
  `aciklama` text COLLATE utf8_turkish_ci NOT NULL,
  `borc` double NOT NULL,
  `tarih` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `musteri`
--

INSERT INTO `musteri` (`musteriId`, `ad`, `soyad`, `telefon`, `adres`, `aciklama`, `borc`, `tarih`) VALUES
(1, 'AHMET', 'ER', '05335662332', 'İstanbul', '30 adet kilim', 2600, '2021-05-21'),
(12, 'FAİK', 'AHMET', '05469687252', 'yalova', 'Koli Sabun 30', 414, '2021-05-21'),
(25, 'HALİL', 'ÖZTÜRK', '0525 265 2252', 'Yalova/Merkez', '10m kum, 3000 Adet Tuğla', 5500, '2021-05-21'),
(26, 'MUSTAFA', 'ERTAŞ', '05374528292', 'istanbul/beyoğlu', '20 koli su, 25 koli meyve suyu', 770, '2021-05-21');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `gecmis`
--
ALTER TABLE `gecmis`
  ADD PRIMARY KEY (`gecmisId`);

--
-- Tablo için indeksler `musteri`
--
ALTER TABLE `musteri`
  ADD PRIMARY KEY (`musteriId`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `gecmis`
--
ALTER TABLE `gecmis`
  MODIFY `gecmisId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=44;

--
-- Tablo için AUTO_INCREMENT değeri `musteri`
--
ALTER TABLE `musteri`
  MODIFY `musteriId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
