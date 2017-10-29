using FuzzyLogic.Logic;
using System;
using System.Collections.Generic;

namespace FuzzyLogic
{
    public class LeagueScenarios
    {
        public string PremierLeague(double x1, double x2, double x3, double x4, double x5)
        {
            //
            // Create empty fuzzy system
            //
            MamdaniFuzzySystem fsGols = new MamdaniFuzzySystem();

            //
            // Create input variables for the system
            //
            FuzzyVariable fvGamer = new FuzzyVariable("gamerLosses", -6.0, 6.0);
            fvGamer.Terms.Add(new FuzzyTerm("x1_BS", new NormalMembershipFunction(-6, 2.55)));
            fvGamer.Terms.Add(new FuzzyTerm("x1_OS", new NormalMembershipFunction(0, 2.55)));
            fvGamer.Terms.Add(new FuzzyTerm("x1_KS", new NormalMembershipFunction(6, 2.55)));
            fsGols.Input.Add(fvGamer);

            FuzzyVariable fvGameDinamics = new FuzzyVariable("gameDinamics", -15.0, 15.0);
            fvGameDinamics.Terms.Add(new FuzzyTerm("x2_SP", new NormalMembershipFunction(-15, 4.25)));
            fvGameDinamics.Terms.Add(new FuzzyTerm("x2_P", new NormalMembershipFunction(-5, 4.25)));
            fvGameDinamics.Terms.Add(new FuzzyTerm("x2_V", new NormalMembershipFunction(5, 4.25)));
            fvGameDinamics.Terms.Add(new FuzzyTerm("x2_SV", new NormalMembershipFunction(15, 4.25)));
            fsGols.Input.Add(fvGameDinamics);

            FuzzyVariable fvClassDifferences = new FuzzyVariable("classDifferences", -19.0, 19.0);
            fvClassDifferences.Terms.Add(new FuzzyTerm("x3_L", new NormalMembershipFunction(-19, 2.76)));
            fvClassDifferences.Terms.Add(new FuzzyTerm("x3_VP", new NormalMembershipFunction(-9.5, 2.76)));
            fvClassDifferences.Terms.Add(new FuzzyTerm("x3_S", new NormalMembershipFunction(0, 2.76)));
            fvClassDifferences.Terms.Add(new FuzzyTerm("x3_NP", new NormalMembershipFunction(9.5, 2.76)));
            fvClassDifferences.Terms.Add(new FuzzyTerm("x3_A", new NormalMembershipFunction(-19, 2.76)));
            fsGols.Input.Add(fvClassDifferences);

            FuzzyVariable fvFieldFactor = new FuzzyVariable("fieldFactor", -2.0, 3.0);
            fvFieldFactor.Terms.Add(new FuzzyTerm("x4_ANd", new NormalMembershipFunction(-2, 0.7)));
            fvFieldFactor.Terms.Add(new FuzzyTerm("x4_Nd", new NormalMembershipFunction(-0.33, 0.7)));
            fvFieldFactor.Terms.Add(new FuzzyTerm("x4_Pr", new NormalMembershipFunction(1.33, 0.7)));
            fvFieldFactor.Terms.Add(new FuzzyTerm("x4_APr", new NormalMembershipFunction(3, 0.7)));
            fsGols.Input.Add(fvFieldFactor);

            FuzzyVariable fvCommandMatches = new FuzzyVariable("commandMatches", -60.0, 60.0);
            fvCommandMatches.Terms.Add(new FuzzyTerm("x5_Pz", new NormalMembershipFunction(-60.0, 8.5)));
            fvCommandMatches.Terms.Add(new FuzzyTerm("x5_R", new NormalMembershipFunction(0, 8.5)));
            fvCommandMatches.Terms.Add(new FuzzyTerm("x5_Rz", new NormalMembershipFunction(60.0, 8.5)));
            fsGols.Input.Add(fvCommandMatches);

            //
            // Create output variables for the system
            //
            FuzzyVariable fvGols = new FuzzyVariable("gols", -3.0, 3.0);
            fvGols.Terms.Add(new FuzzyTerm("y_KP", new NormalMembershipFunction(-3.0, 0.64)));
            fvGols.Terms.Add(new FuzzyTerm("y_P", new NormalMembershipFunction(-0.9, 0.44)));
            fvGols.Terms.Add(new FuzzyTerm("y_N", new NormalMembershipFunction(0, 0.44)));
            fvGols.Terms.Add(new FuzzyTerm("y_V", new NormalMembershipFunction(0.9, 0.44)));
            fvGols.Terms.Add(new FuzzyTerm("y_KV", new NormalMembershipFunction(3.0, 0.64)));
            fsGols.Output.Add(fvGols);

            //
            // Create three fuzzy rules
            //
            MamdaniFuzzyRule rule11 = fsGols.ParseRule("if ((gamerLosses is x1_BS ) and (gameDinamics is x2_SV ) " +
                "and (classDifferences is x3_L) and (fieldFactor is x4_APr) and (commandMatches is x5_Rz)) " +
                "then gols is y_KV");

            MamdaniFuzzyRule rule12 = fsGols.ParseRule("if ((gamerLosses is x1_OS) and (gameDinamics is x2_V)" +
                " and (classDifferences is x3_VP) and (fieldFactor is x4_Pr) and (commandMatches is x5_Rz)) " +
                "then gols is y_KV");

            MamdaniFuzzyRule rule13 = fsGols.ParseRule("if ((gamerLosses is x1_OS) and (gameDinamics is x2_P)" +
                " and (classDifferences is x3_L) and (fieldFactor is x4_Pr) and (commandMatches is x5_Rz)) " +
                "then gols is y_KV");

            MamdaniFuzzyRule rule14 = fsGols.ParseRule("if ((gamerLosses is x1_BS) and (gameDinamics is x2_V) " +
                "and (classDifferences is x3_VP) and (fieldFactor is x4_Pr) and (commandMatches is x5_R)) " +
                "then gols is y_KV");

            MamdaniFuzzyRule rule2 = fsGols.ParseRule("if ((gamerLosses is x1_OS ) and (gameDinamics is x2_V ) " +
                "and (classDifferences is x3_S) and (fieldFactor is x4_Nd) and (commandMatches is x5_Rz)) or " +
                "((gamerLosses is x1_KS) and (gameDinamics is x2_P) and (classDifferences is x3_VP)" +
                "and(fieldFactor is x4_Pr) and (commandMatches is x5_R)) or ((gamerLosses is x1_OS) and " +
                "(gameDinamics is x2_V) and (classDifferences is x3_S) and (fieldFactor is x4_Nd) " +
                "and (commandMatches is x5_Rz)) or ((gamerLosses is x1_BS) and(gameDinamics is x2_SV) " +
                "and (classDifferences is x3_NP) and (fieldFactor is x4_Pr) and (commandMatches is x5_R)) " +
                "then gols is y_V");

            MamdaniFuzzyRule rule3 = fsGols.ParseRule("if ((gamerLosses is x1_OS ) and (gameDinamics is x2_V ) " +
                "and (classDifferences is x3_S) and (fieldFactor is x4_Nd) and (commandMatches is x5_R)) or " +
                "((gamerLosses is x1_KS) and (gameDinamics is x2_SP) and (classDifferences is x3_S)" +
                "and(fieldFactor is x4_Nd) and (commandMatches is x5_R)) or ((gamerLosses is x1_OS) and " +
                "(gameDinamics is x2_P) and (classDifferences is x3_NP) and (fieldFactor is x4_Pr) " +
                "and (commandMatches is x5_Pz)) or ((gamerLosses is x1_BS) and(gameDinamics is x2_SP) " +
                "and (classDifferences is x3_VP) and (fieldFactor is x4_Nd) and (commandMatches is x5_R)) " +
                "then gols is y_N");

            MamdaniFuzzyRule rule4 = fsGols.ParseRule("if ((gamerLosses is x1_BS ) and (gameDinamics is x2_P ) " +
                "and (classDifferences is x3_S) and (fieldFactor is x4_ANd) and (commandMatches is x5_R)) or " +
                "((gamerLosses is x1_OS) and (gameDinamics is x2_V) and (classDifferences is x3_NP)" +
                "and(fieldFactor is x4_Nd) and (commandMatches is x5_Pz)) or ((gamerLosses is x1_KS) and " +
                "(gameDinamics is x2_SP) and (classDifferences is x3_S) and (fieldFactor is x4_Pr) " +
                "and (commandMatches is x5_Pz)) or ((gamerLosses is x1_OS) and(gameDinamics is x2_P) " +
                "and (classDifferences is x3_A) and (fieldFactor is x4_Nd) and (commandMatches is x5_R)) " +
                "then gols is y_P");

            MamdaniFuzzyRule rule5 = fsGols.ParseRule("if ((gamerLosses is x1_KS ) and (gameDinamics is x2_SP ) " +
                "and (classDifferences is x3_A) and (fieldFactor is x4_ANd) and (commandMatches is x5_R)) or " +
                "((gamerLosses is x1_OS) and (gameDinamics is x2_SP) and (classDifferences is x3_NP)" +
                "and(fieldFactor is x4_Nd) and (commandMatches is x5_Pz)) or ((gamerLosses is x1_KS) and " +
                "(gameDinamics is x2_P) and (classDifferences is x3_NP) and (fieldFactor is x4_ANd) " +
                "and (commandMatches is x5_R)) or ((gamerLosses is x1_BS) and(gameDinamics is x2_SP) " +
                "and (classDifferences is x3_NP) and (fieldFactor is x4_Nd) and (commandMatches is x5_Pz)) " +
                "then gols is y_KP");

            fsGols.Rules.Add(rule11);
            fsGols.Rules.Add(rule12);
            fsGols.Rules.Add(rule13);
            fsGols.Rules.Add(rule14);
            fsGols.Rules.Add(rule2);
            fsGols.Rules.Add(rule3);
            fsGols.Rules.Add(rule4);

            //
            // Associate input values with input variables
            //
            Dictionary<FuzzyVariable, double> inputValues = new Dictionary<FuzzyVariable, double>();
            inputValues.Add(fvGamer, x1);
            inputValues.Add(fvGameDinamics, x2);
            inputValues.Add(fvClassDifferences, x3);
            inputValues.Add(fvFieldFactor, x4);
            inputValues.Add(fvCommandMatches, x5);

            //
            // Calculate result: one output value for each output variable
            //
            Dictionary<FuzzyVariable, double> result = fsGols.Calculate(inputValues);

            //
            // Get output value for the 'tips' variable
            //
            Console.WriteLine(result[fvGols].ToString("f1"));

            return result[fvGols].ToString("f1");
        }
    }
}
