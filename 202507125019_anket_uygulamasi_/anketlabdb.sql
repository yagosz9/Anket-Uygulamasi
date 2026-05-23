-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3307
-- Üretim Zamanı: 20 May 2026, 17:41:05
-- Sunucu sürümü: 10.4.32-MariaDB
-- PHP Sürümü: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `anketlabdb`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `anketler`
--

CREATE TABLE `anketler` (
  `id` int(11) NOT NULL,
  `baslik` varchar(100) NOT NULL,
  `kategori_id` int(11) NOT NULL,
  `olusturan_id` int(11) NOT NULL,
  `tarih` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `anketler`
--

INSERT INTO `anketler` (`id`, `baslik`, `kategori_id`, `olusturan_id`, `tarih`) VALUES
(3, 'Türkiyenin En iyi Spor Kulübü', 2, 1, '2026-05-20 16:19:39'),
(4, 'Ders Memnuniyet Anketi', 1, 1, '2026-05-20 18:11:52'),
(5, 'Kampüs Etkinliği Geri Bildirim Anketi', 4, 1, '2026-05-20 18:35:38'),
(6, 'Tarih Dersi İlgi Anketi', 3, 1, '2026-05-20 18:38:33');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `cevaplar`
--

CREATE TABLE `cevaplar` (
  `id` int(11) NOT NULL,
  `soru_id` int(11) NOT NULL,
  `kullanici_id` int(11) NOT NULL,
  `cevap` varchar(255) NOT NULL,
  `tarih` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `cevaplar`
--

INSERT INTO `cevaplar` (`id`, `soru_id`, `kullanici_id`, `cevap`, `tarih`) VALUES
(5, 6, 2, 'Evet', '2026-05-20 18:39:08'),
(6, 4, 2, 'Evet', '2026-05-20 18:39:12');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kategoriler`
--

CREATE TABLE `kategoriler` (
  `id` int(11) NOT NULL,
  `kategori_adi` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `kategoriler`
--

INSERT INTO `kategoriler` (`id`, `kategori_adi`) VALUES
(1, 'Eğitim'),
(2, 'Spor'),
(3, 'Tarih'),
(4, 'Sosyal');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanicilar`
--

CREATE TABLE `kullanicilar` (
  `id` int(11) NOT NULL,
  `kullanici_adi` varchar(50) NOT NULL,
  `sifre` varchar(50) NOT NULL,
  `rol` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `kullanicilar`
--

INSERT INTO `kullanicilar` (`id`, `kullanici_adi`, `sifre`, `rol`) VALUES
(1, 'admin', '123', 'Admin'),
(2, 'user', '123', 'User');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `secenekler`
--

CREATE TABLE `secenekler` (
  `id` int(11) NOT NULL,
  `soru_id` int(11) NOT NULL,
  `secenek_metni` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `secenekler`
--

INSERT INTO `secenekler` (`id`, `soru_id`, `secenek_metni`) VALUES
(5, 2, 'Evet'),
(6, 2, 'Hayır'),
(7, 2, 'Kısmen'),
(8, 2, 'Kararsızım'),
(9, 3, 'Evet'),
(10, 3, 'Hayır'),
(11, 3, 'Kısmen'),
(12, 3, 'Kararsızım'),
(13, 4, 'Evet'),
(14, 4, 'Hayır'),
(15, 4, 'Kısmen'),
(16, 4, 'Kararsızım'),
(17, 5, 'Evet'),
(18, 5, 'Hayır'),
(19, 5, 'Bazen'),
(20, 5, 'Fikrim Yok'),
(21, 6, 'Evet'),
(22, 6, 'Hayır'),
(23, 6, 'Kısmen'),
(24, 6, 'Kararsızım');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sorular`
--

CREATE TABLE `sorular` (
  `id` int(11) NOT NULL,
  `anket_id` int(11) NOT NULL,
  `soru_metni` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `sorular`
--

INSERT INTO `sorular` (`id`, `anket_id`, `soru_metni`) VALUES
(3, 3, 'Türkiyenin en iyi Spor Kulübü Fenerbahçedir!'),
(4, 4, 'Derslerden genel olarak memnun musunuz?'),
(5, 5, '23.05.2026 tarihinde yapılacak kampüs etkinliğine katılmak ister misiniz?'),
(6, 6, 'Tarih konularının görseller ve örnek olaylarla anlatılması dersi daha anlaşılır hale getirir mi?');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `anketler`
--
ALTER TABLE `anketler`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `cevaplar`
--
ALTER TABLE `cevaplar`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `kategoriler`
--
ALTER TABLE `kategoriler`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `kullanicilar`
--
ALTER TABLE `kullanicilar`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `secenekler`
--
ALTER TABLE `secenekler`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sorular`
--
ALTER TABLE `sorular`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `anketler`
--
ALTER TABLE `anketler`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Tablo için AUTO_INCREMENT değeri `cevaplar`
--
ALTER TABLE `cevaplar`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Tablo için AUTO_INCREMENT değeri `kategoriler`
--
ALTER TABLE `kategoriler`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Tablo için AUTO_INCREMENT değeri `kullanicilar`
--
ALTER TABLE `kullanicilar`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Tablo için AUTO_INCREMENT değeri `secenekler`
--
ALTER TABLE `secenekler`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- Tablo için AUTO_INCREMENT değeri `sorular`
--
ALTER TABLE `sorular`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
