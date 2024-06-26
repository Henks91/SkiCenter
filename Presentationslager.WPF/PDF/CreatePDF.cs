﻿using ceTe.DynamicPDF;
using ceTe.DynamicPDF.PageElements;
using Entiteter.Personer;
using Entiteter.Tjänster;
using System.Collections.Generic;

namespace PDF
{
    class CreatePDF
    {
        public static void RunP(Privatkund privatkund, MasterBokning masterbokning, double? totalpris, double? totalprisrabatt, IList<Logi> logis)
        {
            Document document = new Document();

            Page page = new Page(PageSize.Letter, PageOrientation.Portrait, 54.0f);
            document.Pages.Add(page);

            string labelText =
                $"\nBokningsbekräftelse" +
                $"\nBokningsnummer: {masterbokning.BokningsNr}" +
                $"\nPersonnummer: {privatkund.Personnummer}" +
                $"\nIncheckningsdatum: {masterbokning.StartDatum}" +
                $"\nUtcheckningsdatum: {masterbokning.SlutDatum}" +
                $"\nTotalpris: {totalpris}" +
                $"\nTotalpris inklusive rabatt: {totalprisrabatt}";

            //foreach (Logi logi in logis)
            //{
            //    Label label2 = new Label(logi.Typen, 0, 0, 504, 500, Font.Helvetica, 18, TextAlign.Center);
            //}

            //string combinedString = string.Join(",", logis);
            //string test = labelText + combinedString;
            Label label = new Label(labelText, 0, 0, 504, 500, Font.Helvetica, 18, TextAlign.Center);
            page.Elements.Add(label);
            //page.Elements.Add(label2);


            document.Draw(Util.GetPath($"PDF/{masterbokning.BokningsNr}.pdf"));
        }

        public static void RunF(Företagskund företagskund, MasterBokning masterbokning, double? totalpris, double? totalprisrabatt, IList<Logi> logis)
        {
            Document document = new Document();

            Page page = new Page(PageSize.Letter, PageOrientation.Portrait, 54.0f);
            document.Pages.Add(page);

            string labelText =
                $"\nBokningsbekräftelse" +
                $"\nBokningsnummer: {masterbokning.BokningsNr}" +
                $"\nPersonnummer: {företagskund.OrgNr}" +
                $"\nIncheckningsdatum: {masterbokning.StartDatum}" +
                $"\nUtcheckningsdatum: {masterbokning.SlutDatum}" +
                $"\nTotalpris: {totalpris}" +
                $"\nTotalpris inklusive rabatt: {totalprisrabatt}";

            //foreach (Logi logi in logis)
            //{
            //    Label label2 = new Label(logi.Typen, 0, 0, 504, 500, Font.Helvetica, 18, TextAlign.Center);
            //}

            //string combinedString = string.Join(",", logis);
            //string test = labelText + combinedString;
            Label label = new Label(labelText, 0, 0, 504, 500, Font.Helvetica, 18, TextAlign.Center);
            page.Elements.Add(label);
            //page.Elements.Add(label2);


            document.Draw(Util.GetPath($"PDF/{masterbokning.BokningsNr}.pdf"));
        }
    }
}
