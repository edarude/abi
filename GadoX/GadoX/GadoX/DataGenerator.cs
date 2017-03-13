using System;
using System.Collections.Generic;

namespace GadoX {
	public class DataGenerator {

		public void DataGenen(){
			GadoGenerator();
		}

		public void GadoGenerator(){
			var Connection = new UnityOfWork();

			var listDeGado = new List<Gado>();

			listDeGado.Add(new Gado { IDGado = 1, MesDeNascimento = 12, AnoDeNascimento = 2014, Genero = Sexo.Macho, Numeracao = 152, IdVacaMae = 0, IDSituacao = 3, IsTouro = true , NumeroDeCrias = 7});
			listDeGado.Add(new Gado { IDGado = 2, MesDeNascimento = 12, AnoDeNascimento = 2013, Genero = Sexo.Fêmea, Numeracao = 3, IdVacaMae = 1, IDSituacao = 2, IsTouro = false, NumeroDeCrias = 7 });
			listDeGado.Add(new Gado { IDGado = 3, MesDeNascimento = 3, AnoDeNascimento = 2012, Genero = Sexo.Fêmea, Numeracao = 22, IdVacaMae = 1, IDSituacao = 0, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 4, MesDeNascimento = 8, AnoDeNascimento = 2000, Genero = Sexo.Fêmea, Numeracao = 163, IdVacaMae = 2, IDSituacao = 3, IsTouro = true , NumeroDeCrias = 7});
			listDeGado.Add(new Gado { IDGado = 5, MesDeNascimento = 4, AnoDeNascimento = 2013, Genero = Sexo.Macho, Numeracao = 65, IdVacaMae = 4, IDSituacao = 3, IsTouro = true , NumeroDeCrias = 3});
			listDeGado.Add(new Gado { IDGado = 6, MesDeNascimento = 9, AnoDeNascimento = 2001, Genero = Sexo.Macho, Numeracao = 133, IdVacaMae = 3, IDSituacao = 3, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 7, MesDeNascimento = 9, AnoDeNascimento = 2003, Genero = Sexo.Fêmea, Numeracao = 64, IdVacaMae = 3, IDSituacao = 1, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 8, MesDeNascimento = 9, AnoDeNascimento = 2004, Genero = Sexo.Fêmea, Numeracao = 169, IdVacaMae = 1, IDSituacao = 0, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 9, MesDeNascimento = 1, AnoDeNascimento = 2011, Genero = Sexo.Macho, Numeracao = 119, IdVacaMae = 4, IDSituacao = 3, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 10, MesDeNascimento = 8, AnoDeNascimento = 2011, Genero = Sexo.Fêmea, Numeracao = 61, IdVacaMae = 3, IDSituacao = 1, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 11, MesDeNascimento = 2, AnoDeNascimento = 2001, Genero = Sexo.Fêmea, Numeracao = 37, IdVacaMae = 8, IDSituacao = 3, IsTouro = true , NumeroDeCrias = 7});
			listDeGado.Add(new Gado { IDGado = 12, MesDeNascimento = 11, AnoDeNascimento = 2011, Genero = Sexo.Macho, Numeracao = 178, IdVacaMae = 3, IDSituacao = 1, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 13, MesDeNascimento = 1, AnoDeNascimento = 2012, Genero = Sexo.Macho, Numeracao = 12, IdVacaMae = 5, IDSituacao = 2, IsTouro = false, NumeroDeCrias = 7 });
			listDeGado.Add(new Gado { IDGado = 14, MesDeNascimento = 2, AnoDeNascimento = 2005, Genero = Sexo.Macho, Numeracao = 159, IdVacaMae = 4, IDSituacao = 2, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 15, MesDeNascimento = 9, AnoDeNascimento = 2005, Genero = Sexo.Macho, Numeracao = 171, IdVacaMae = 13, IDSituacao = 2, IsTouro = false, NumeroDeCrias = 7 });
			listDeGado.Add(new Gado { IDGado = 16, MesDeNascimento = 3, AnoDeNascimento = 2013, Genero = Sexo.Fêmea, Numeracao = 197, IdVacaMae = 4, IDSituacao = 3, IsTouro = true , NumeroDeCrias = 3});
			listDeGado.Add(new Gado { IDGado = 17, MesDeNascimento = 6, AnoDeNascimento = 2016, Genero = Sexo.Macho, Numeracao = 122, IdVacaMae = 13, IDSituacao = 2, IsTouro = false, NumeroDeCrias = 7 });
			listDeGado.Add(new Gado { IDGado = 18, MesDeNascimento = 3, AnoDeNascimento = 2000, Genero = Sexo.Macho, Numeracao = 66, IdVacaMae = 6, IDSituacao = 0, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 19, MesDeNascimento = 7, AnoDeNascimento = 2007, Genero = Sexo.Fêmea, Numeracao = 49, IdVacaMae = 5, IDSituacao = 3, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 20, MesDeNascimento = 12, AnoDeNascimento = 2009, Genero = Sexo.Fêmea, Numeracao = 169, IdVacaMae = 14, IDSituacao = 1, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 21, MesDeNascimento = 5, AnoDeNascimento = 2014, Genero = Sexo.Fêmea, Numeracao = 142, IdVacaMae = 20, IDSituacao = 3, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 22, MesDeNascimento = 9, AnoDeNascimento = 2015, Genero = Sexo.Fêmea, Numeracao = 143, IdVacaMae = 20, IDSituacao = 1, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 23, MesDeNascimento = 5, AnoDeNascimento = 2016, Genero = Sexo.Fêmea, Numeracao = 99, IdVacaMae = 11, IDSituacao = 1, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 24, MesDeNascimento = 12, AnoDeNascimento = 2010, Genero = Sexo.Macho, Numeracao = 19, IdVacaMae = 7, IDSituacao = 2, IsTouro = false, NumeroDeCrias = 7 });
			listDeGado.Add(new Gado { IDGado = 25, MesDeNascimento = 12, AnoDeNascimento = 2002, Genero = Sexo.Macho, Numeracao = 157, IdVacaMae = 9, IDSituacao = 3, IsTouro = true , NumeroDeCrias = 7});
			listDeGado.Add(new Gado { IDGado = 26, MesDeNascimento = 3, AnoDeNascimento = 2009, Genero = Sexo.Macho, Numeracao = 138, IdVacaMae = 1, IDSituacao = 2, IsTouro = false, NumeroDeCrias = 7 });
			listDeGado.Add(new Gado { IDGado = 27, MesDeNascimento = 9, AnoDeNascimento = 2002, Genero = Sexo.Macho, Numeracao = 13, IdVacaMae = 19, IDSituacao = 2, IsTouro = false, NumeroDeCrias = 7 });
			listDeGado.Add(new Gado { IDGado = 28, MesDeNascimento = 12, AnoDeNascimento = 2007, Genero = Sexo.Macho, Numeracao = 133, IdVacaMae = 16, IDSituacao = 2, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 29, MesDeNascimento = 10, AnoDeNascimento = 2004, Genero = Sexo.Macho, Numeracao = 110, IdVacaMae = 24, IDSituacao = 3, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 30, MesDeNascimento = 6, AnoDeNascimento = 2012, Genero = Sexo.Macho, Numeracao = 40, IdVacaMae = 19, IDSituacao = 2, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 31, MesDeNascimento = 9, AnoDeNascimento = 2008, Genero = Sexo.Fêmea, Numeracao = 72, IdVacaMae = 19, IDSituacao = 3, IsTouro = true , NumeroDeCrias = 7});
			listDeGado.Add(new Gado { IDGado = 32, MesDeNascimento = 2, AnoDeNascimento = 2009, Genero = Sexo.Fêmea, Numeracao = 172, IdVacaMae = 22, IDSituacao = 1, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 33, MesDeNascimento = 3, AnoDeNascimento = 2009, Genero = Sexo.Fêmea, Numeracao = 36, IdVacaMae = 29, IDSituacao = 2, IsTouro = false, NumeroDeCrias = 7 });
			listDeGado.Add(new Gado { IDGado = 34, MesDeNascimento = 4, AnoDeNascimento = 2006, Genero = Sexo.Macho, Numeracao = 38, IdVacaMae = 33, IDSituacao = 2, IsTouro = false, NumeroDeCrias = 7 });
			listDeGado.Add(new Gado { IDGado = 35, MesDeNascimento = 5, AnoDeNascimento = 2015, Genero = Sexo.Fêmea, Numeracao = 136, IdVacaMae = 32, IDSituacao = 3, IsTouro = true , NumeroDeCrias = 7});
			listDeGado.Add(new Gado { IDGado = 36, MesDeNascimento = 12, AnoDeNascimento = 2009, Genero = Sexo.Fêmea, Numeracao = 177, IdVacaMae = 33, IDSituacao = 1, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 37, MesDeNascimento = 8, AnoDeNascimento = 2013, Genero = Sexo.Fêmea, Numeracao = 70, IdVacaMae = 22, IDSituacao = 0, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 38, MesDeNascimento = 7, AnoDeNascimento = 2015, Genero = Sexo.Fêmea, Numeracao = 127, IdVacaMae = 15, IDSituacao = 3, IsTouro = true , NumeroDeCrias = 7});
			listDeGado.Add(new Gado { IDGado = 39, MesDeNascimento = 7, AnoDeNascimento = 2003, Genero = Sexo.Macho, Numeracao = 21, IdVacaMae = 17, IDSituacao = 0, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 40, MesDeNascimento = 10, AnoDeNascimento = 2015, Genero = Sexo.Fêmea, Numeracao = 35, IdVacaMae = 24, IDSituacao = 2, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 41, MesDeNascimento = 5, AnoDeNascimento = 2004, Genero = Sexo.Fêmea, Numeracao = 161, IdVacaMae = 4, IDSituacao = 3, IsTouro = true , NumeroDeCrias = 3});
			listDeGado.Add(new Gado { IDGado = 42, MesDeNascimento = 3, AnoDeNascimento = 2006, Genero = Sexo.Macho, Numeracao = 153, IdVacaMae = 23, IDSituacao = 2, IsTouro = false, NumeroDeCrias = 7 });
			listDeGado.Add(new Gado { IDGado = 43, MesDeNascimento = 9, AnoDeNascimento = 2009, Genero = Sexo.Fêmea, Numeracao = 29, IdVacaMae = 37, IDSituacao = 0, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 44, MesDeNascimento = 2, AnoDeNascimento = 2002, Genero = Sexo.Fêmea, Numeracao = 7, IdVacaMae = 35, IDSituacao = 1, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 45, MesDeNascimento = 1, AnoDeNascimento = 2009, Genero = Sexo.Fêmea, Numeracao = 143, IdVacaMae = 29, IDSituacao = 0, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 46, MesDeNascimento = 10, AnoDeNascimento = 2007, Genero = Sexo.Fêmea, Numeracao = 154, IdVacaMae = 27, IDSituacao = 3, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 47, MesDeNascimento = 10, AnoDeNascimento = 2001, Genero = Sexo.Fêmea, Numeracao = 55, IdVacaMae = 38, IDSituacao = 2, IsTouro = false, NumeroDeCrias = 7 });
			listDeGado.Add(new Gado { IDGado = 48, MesDeNascimento = 11, AnoDeNascimento = 2012, Genero = Sexo.Macho, Numeracao = 18, IdVacaMae = 38, IDSituacao = 3, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 49, MesDeNascimento = 6, AnoDeNascimento = 2008, Genero = Sexo.Macho, Numeracao = 3, IdVacaMae = 47, IDSituacao = 3, IsTouro = true , NumeroDeCrias = 7});
			listDeGado.Add(new Gado { IDGado = 50, MesDeNascimento = 4, AnoDeNascimento = 2012, Genero = Sexo.Macho, Numeracao = 103, IdVacaMae = 5, IDSituacao = 1, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 51, MesDeNascimento = 2, AnoDeNascimento = 2005, Genero = Sexo.Macho, Numeracao = 138, IdVacaMae = 16, IDSituacao = 2, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 52, MesDeNascimento = 11, AnoDeNascimento = 2003, Genero = Sexo.Macho, Numeracao = 130, IdVacaMae = 39, IDSituacao = 0, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 53, MesDeNascimento = 12, AnoDeNascimento = 2013, Genero = Sexo.Fêmea, Numeracao = 123, IdVacaMae = 14, IDSituacao = 3, IsTouro = true , NumeroDeCrias = 7});
			listDeGado.Add(new Gado { IDGado = 54, MesDeNascimento = 11, AnoDeNascimento = 2002, Genero = Sexo.Macho, Numeracao = 33, IdVacaMae = 32, IDSituacao = 0, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 55, MesDeNascimento = 3, AnoDeNascimento = 2008, Genero = Sexo.Fêmea, Numeracao = 173, IdVacaMae = 19, IDSituacao = 1, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 56, MesDeNascimento = 4, AnoDeNascimento = 2011, Genero = Sexo.Macho, Numeracao = 23, IdVacaMae = 9, IDSituacao = 1, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 57, MesDeNascimento = 1, AnoDeNascimento = 2008, Genero = Sexo.Macho, Numeracao = 131, IdVacaMae = 38, IDSituacao = 0, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 58, MesDeNascimento = 6, AnoDeNascimento = 2008, Genero = Sexo.Fêmea, Numeracao = 193, IdVacaMae = 3, IDSituacao = 3, IsTouro = true , NumeroDeCrias = 7});
			listDeGado.Add(new Gado { IDGado = 59, MesDeNascimento = 2, AnoDeNascimento = 2016, Genero = Sexo.Macho, Numeracao = 82, IdVacaMae = 11, IDSituacao = 1, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 60, MesDeNascimento = 2, AnoDeNascimento = 2005, Genero = Sexo.Macho, Numeracao = 82, IdVacaMae = 17, IDSituacao = 0, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 61, MesDeNascimento = 9, AnoDeNascimento = 2006, Genero = Sexo.Fêmea, Numeracao = 49, IdVacaMae = 36, IDSituacao = 1, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 62, MesDeNascimento = 11, AnoDeNascimento = 2010, Genero = Sexo.Macho, Numeracao = 98, IdVacaMae = 20, IDSituacao = 2, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 63, MesDeNascimento = 1, AnoDeNascimento = 2003, Genero = Sexo.Macho, Numeracao = 66, IdVacaMae = 17, IDSituacao = 0, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 64, MesDeNascimento = 2, AnoDeNascimento = 2008, Genero = Sexo.Macho, Numeracao = 170, IdVacaMae = 21, IDSituacao = 0, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 65, MesDeNascimento = 11, AnoDeNascimento = 2002, Genero = Sexo.Fêmea, Numeracao = 66, IdVacaMae = 61, IDSituacao = 0, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 66, MesDeNascimento = 8, AnoDeNascimento = 2014, Genero = Sexo.Fêmea, Numeracao = 149, IdVacaMae = 59, IDSituacao = 0, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 67, MesDeNascimento = 4, AnoDeNascimento = 2001, Genero = Sexo.Fêmea, Numeracao = 107, IdVacaMae = 38, IDSituacao = 1, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 68, MesDeNascimento = 3, AnoDeNascimento = 2011, Genero = Sexo.Fêmea, Numeracao = 62, IdVacaMae = 57, IDSituacao = 1, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 69, MesDeNascimento = 1, AnoDeNascimento = 2009, Genero = Sexo.Fêmea, Numeracao = 6, IdVacaMae = 47, IDSituacao = 1, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 70, MesDeNascimento = 8, AnoDeNascimento = 2010, Genero = Sexo.Fêmea, Numeracao = 122, IdVacaMae = 65, IDSituacao = 0, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 71, MesDeNascimento = 8, AnoDeNascimento = 2013, Genero = Sexo.Fêmea, Numeracao = 124, IdVacaMae = 21, IDSituacao = 0, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 72, MesDeNascimento = 7, AnoDeNascimento = 2006, Genero = Sexo.Macho, Numeracao = 4, IdVacaMae = 30, IDSituacao = 3, IsTouro = true , NumeroDeCrias = 7});
			listDeGado.Add(new Gado { IDGado = 73, MesDeNascimento = 10, AnoDeNascimento = 2001, Genero = Sexo.Macho, Numeracao = 59, IdVacaMae = 9, IDSituacao = 0, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 74, MesDeNascimento = 1, AnoDeNascimento = 2011, Genero = Sexo.Macho, Numeracao = 189, IdVacaMae = 30, IDSituacao = 3, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 75, MesDeNascimento = 8, AnoDeNascimento = 2009, Genero = Sexo.Fêmea, Numeracao = 106, IdVacaMae = 61, IDSituacao = 2, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 76, MesDeNascimento = 1, AnoDeNascimento = 2009, Genero = Sexo.Macho, Numeracao = 172, IdVacaMae = 32, IDSituacao = 0, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 77, MesDeNascimento = 1, AnoDeNascimento = 2011, Genero = Sexo.Fêmea, Numeracao = 145, IdVacaMae = 27, IDSituacao = 0, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 78, MesDeNascimento = 9, AnoDeNascimento = 2007, Genero = Sexo.Fêmea, Numeracao = 110, IdVacaMae = 51, IDSituacao = 2, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 79, MesDeNascimento = 1, AnoDeNascimento = 2006, Genero = Sexo.Fêmea, Numeracao = 174, IdVacaMae = 34, IDSituacao = 2, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 80, MesDeNascimento = 10, AnoDeNascimento = 2011, Genero = Sexo.Fêmea, Numeracao = 9, IdVacaMae = 14, IDSituacao = 0, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 81, MesDeNascimento = 7, AnoDeNascimento = 2015, Genero = Sexo.Macho, Numeracao = 117, IdVacaMae = 29, IDSituacao = 1, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 82, MesDeNascimento = 5, AnoDeNascimento = 2000, Genero = Sexo.Macho, Numeracao = 165, IdVacaMae = 8, IDSituacao = 2, IsTouro = false, NumeroDeCrias = 7 });
			listDeGado.Add(new Gado { IDGado = 83, MesDeNascimento = 5, AnoDeNascimento = 2014, Genero = Sexo.Fêmea, Numeracao = 87, IdVacaMae = 57, IDSituacao = 3, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 84, MesDeNascimento = 7, AnoDeNascimento = 2013, Genero = Sexo.Macho, Numeracao = 43, IdVacaMae = 48, IDSituacao = 1, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 85, MesDeNascimento = 5, AnoDeNascimento = 2013, Genero = Sexo.Fêmea, Numeracao = 164, IdVacaMae = 58, IDSituacao = 2, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 86, MesDeNascimento = 2, AnoDeNascimento = 2000, Genero = Sexo.Macho, Numeracao = 184, IdVacaMae = 65, IDSituacao = 0, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 87, MesDeNascimento = 11, AnoDeNascimento = 2006, Genero = Sexo.Fêmea, Numeracao = 138, IdVacaMae = 23, IDSituacao = 3, IsTouro = true , NumeroDeCrias = 7});
			listDeGado.Add(new Gado { IDGado = 88, MesDeNascimento = 8, AnoDeNascimento = 2016, Genero = Sexo.Fêmea, Numeracao = 175, IdVacaMae = 64, IDSituacao = 3, IsTouro = true , NumeroDeCrias = 7});
			listDeGado.Add(new Gado { IDGado = 89, MesDeNascimento = 11, AnoDeNascimento = 2003, Genero = Sexo.Fêmea, Numeracao = 38, IdVacaMae = 21, IDSituacao = 2, IsTouro = false, NumeroDeCrias = 7 });
			listDeGado.Add(new Gado { IDGado = 90, MesDeNascimento = 9, AnoDeNascimento = 2007, Genero = Sexo.Macho, Numeracao = 80, IdVacaMae = 82, IDSituacao = 2, IsTouro = false, NumeroDeCrias = 7 });
			listDeGado.Add(new Gado { IDGado = 91, MesDeNascimento = 8, AnoDeNascimento = 2000, Genero = Sexo.Macho, Numeracao = 12, IdVacaMae = 35, IDSituacao = 1, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 92, MesDeNascimento = 3, AnoDeNascimento = 2015, Genero = Sexo.Fêmea, Numeracao = 130, IdVacaMae = 80, IDSituacao = 1, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 93, MesDeNascimento = 10, AnoDeNascimento = 2011, Genero = Sexo.Fêmea, Numeracao = 105, IdVacaMae = 16, IDSituacao = 3, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 94, MesDeNascimento = 7, AnoDeNascimento = 2014, Genero = Sexo.Fêmea, Numeracao = 22, IdVacaMae = 83, IDSituacao = 3, IsTouro = true , NumeroDeCrias = 7});
			listDeGado.Add(new Gado { IDGado = 95, MesDeNascimento = 11, AnoDeNascimento = 2006, Genero = Sexo.Fêmea, Numeracao = 155, IdVacaMae = 56, IDSituacao = 1, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 96, MesDeNascimento = 5, AnoDeNascimento = 2003, Genero = Sexo.Macho, Numeracao = 129, IdVacaMae = 95, IDSituacao = 1, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 97, MesDeNascimento = 12, AnoDeNascimento = 2004, Genero = Sexo.Macho, Numeracao = 102, IdVacaMae = 65, IDSituacao = 0, IsTouro = false, NumeroDeCrias = 5 });
			listDeGado.Add(new Gado { IDGado = 98, MesDeNascimento = 9, AnoDeNascimento = 2000, Genero = Sexo.Macho, Numeracao = 49, IdVacaMae = 75, IDSituacao = 3, IsTouro = true , NumeroDeCrias = 7});
			listDeGado.Add(new Gado { IDGado = 99, MesDeNascimento = 6, AnoDeNascimento = 2015, Genero = Sexo.Fêmea, Numeracao = 60, IdVacaMae = 71, IDSituacao = 1, IsTouro = true , NumeroDeCrias = 5});
			listDeGado.Add(new Gado { IDGado = 100, MesDeNascimento = 8, AnoDeNascimento = 2012, Genero = Sexo.Fêmea, Numeracao = 110, IdVacaMae = 7, IDSituacao = 3, IsTouro = true , NumeroDeCrias = 7});

			Connection.GadoRepository.AddOrUpdateAll(listDeGado);

			Connection.Commit();
			Connection.Dispose();

		}
	}
}
