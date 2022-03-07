using InteractiveProject;
using InteractiveProject.Helper;

namespace Interactive_Saga
{
    public static class MessageHelper
    {
        public static void WelcomeMessage()
        {
            if (ConsoleHelper.IsTestMode) { return; }
            Console.ForegroundColor = ConsoleColor.Cyan;
            ConsoleHelper.Write("      *  ' *    ''  **            **                                  '*   *      * ''  ");
            ConsoleHelper.Write("* *  ' *    ''        ***   ''****                  **             '*   *   ' *    ''*  ");
            ConsoleHelper.Write("*     *  '      ''  **                ''  **         *   *      ''    '* * *      *   * ");
            ConsoleHelper.Write("* *  '      ''  **          ''**                                            *     *     ");
            ConsoleHelper.Write("  *  ' *    ''    ''  **         **     ''   '*** *                 '    '***  *        ");
            ConsoleHelper.Write("      *  ' *    ''  **        **                     **            '* * *      * ''     ");
            ConsoleHelper.Write("  *  ' *    ''        ***            '                             * '***  *    ''   *  ");
            ConsoleHelper.Write("*        ' *    ''  **                ''*  *         **      ''    '    *      *      * ");
            ConsoleHelper.Write("  *  ' *    ''  **          ''*  *                                   **     ''          ");
            ConsoleHelper.Write("*        ' *    ''  **        **      ''*  *         **            '* *    *      * ''  ");
            ConsoleHelper.Write("  *  ' *    ''  *                *  *'                     *        *         *    ''*  ");
            ConsoleHelper.Write(" *         *              *    **                    *                            *     ");
            ConsoleHelper.Write("      *          * *                       *                                *           ");
            Thread.Sleep(2000);
            ConsoleHelper.Clear();

            Console.ForegroundColor = ConsoleColor.White;
            ConsoleHelper.Write("      *  ' *    ''  **            **                                  '* * *      * ''  ");
            ConsoleHelper.Write("* *  ' *    ''        ***   ''****                  **             '  * *   ' *    ''*  ");
            ConsoleHelper.Write("*     *  '      ''  **                ''  **         *   *      ''    '* * *      *   * ");
            ConsoleHelper.Write("    ''  **          ''**                                   *        *             *     ");
            ConsoleHelper.Write("  *  ' *    ''    ''  **         **     ''   '*** *                 '    '     *        ");
            ConsoleHelper.Write("*     *  ' *    ''  **        **                     **            '*   *      * ''     ");
            ConsoleHelper.Write("' *    ''  **      *            '                             * '*     **  *    ''   *  ");
            ConsoleHelper.Write("    *  ' *    ''  **                ''*  *         **      ''    '    *      *        * ");
            ConsoleHelper.Write("  *  ' *    ''  **          ''*  *                                    *     ''          ");
            ConsoleHelper.Write("   ''  **        **      ''*  *         **            '*             **    *      * ''  ");
            ConsoleHelper.Write("*        ' *    ''  **                ''             **      ''                   *   * ");
            ConsoleHelper.Write("   ''              ''****         **     ''   '*** *       '  * '*         **     *     ");
            ConsoleHelper.Write("*     *  ' *    ''  **        **      ''** *         **            '  * *      * ''     ");
            ConsoleHelper.Write("* *  ' *    ''  **    ***   ''             **                        '  *     *    ''*  ");
            ConsoleHelper.Write("   ''  **                ''             **      ''    '**             * *         *   * ");
            ConsoleHelper.Write("* *  ' *    '  ***          ''****         **     ''   '*** *       '    '***  *        ");
            ConsoleHelper.Write("*     *  ' *    ''  **        **      ''****         **            '    *      * ''     ");
            ConsoleHelper.Write("     ' *    ''  **    ***   ''*  *         **                              *    ''*     ");
            ConsoleHelper.Write("*        ' *    ''  **                ''  **         **      ''    '*** *         *   * ");
            ConsoleHelper.Write("     ' *    ''  **          ''****         **     ''   '    *       ' ** '        *     ");
            ConsoleHelper.Write("     ''  *                *  *'                     *        *         *    ''*         ");
            ConsoleHelper.Write("        *              *    **                    *                            *        ");
            ConsoleHelper.Write("      *          * *                       *                                *           ");
            Thread.Sleep(2000);
            ConsoleHelper.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            ConsoleHelper.Write("*     *  ' *    ''  **        **      ''                **            '    *      * ''  ");
            ConsoleHelper.Write("    ''  **    ***   ''**     **                   '                   *            ''*  ");
            ConsoleHelper.Write("*     *  ' *    ''                    ''  **         *   *      ''    '  * *      *   * ");
            ConsoleHelper.Write("   ''  **          ''  **       **       ''   '*   ** *       '             '***  *     ");
            ConsoleHelper.Write("*     *  ' *    ''  **        **      ''*  *         **               '*** *      * ''  ");
            ConsoleHelper.Write("    ''  **    ***   ''*  *   *                 '*** *              '  *       *    ''*  ");
            ConsoleHelper.Write("*     *  ' *    ''  **                ''*  *         **      ''       '    *      *   * ");
            ConsoleHelper.Write("    ''  **          ''              *     ''                 *                    *     ");
            ConsoleHelper.Write("*     *  ' *    ''  **        **      ''             **            '       *      * ''  ");
            ConsoleHelper.Write("* *  ' *    ''  **    ***   ''*  *         **          '                      *    ''*  ");
            ConsoleHelper.Write("     *  ' *    ''  **                ''****         **       ''    '    *         *   * ");
            ConsoleHelper.Write("  *  ' *    ''  **          ''             **     ''   '*** *       '    '***  *        ");
            ConsoleHelper.Write("      *  ' *    ''  **        **      ''   *         **            '    *      * ''     ");
            ConsoleHelper.Write("  ' *    ''  **    ***   '   '        **                     *                *    ''*  ");
            ConsoleHelper.Write("     *  ' *    ''  **                 ''*  *         **      ''    '*** *         *   * ");
            ConsoleHelper.Write(" *  '      ''               ''****         **     ''   '  * *       '    '***  *        ");
            ConsoleHelper.Write("*     *  ' *    ''  **        **  ''****             **            '* * *      * ''     ");
            ConsoleHelper.Write(" *  '      ''        ** *   ''                **       '                        ''   *  ");
            ConsoleHelper.Write("     *  ' *    ''  **                 ''             **      ''    '* * *      *      * ");
            ConsoleHelper.Write("                            ''   *                ''   '*** *       '    '***  *        ");
            ConsoleHelper.Write("     *  ' *    ''   **        **      ''             **            '* * *      * ''     ");
            ConsoleHelper.Write("  *  ' *    ''  **    ***   ''*  *         **          '  * *   '    '* *  *    ''*     ");
            ConsoleHelper.Write("     *  ' *    ''   **                ''****         **      ''    '*   *         *   * ");
            ConsoleHelper.Write(" *  ' *    ''  * *          ''*  *                ''   '*** *       '    '* *     *     ");
            ConsoleHelper.Write("     *  ' *     ''  **        **      ''**    **         **         '    *     * ''     ");
            ConsoleHelper.Write("  ' *    ''     **    ***   ''*  *         **          '             '  *     *    ''*  ");
            ConsoleHelper.Write("*     *  ' *    ''  **                ''             **      ''    '*** *         *   * ");
            ConsoleHelper.Write("  ' *       '  ***          ''**           **     ''   '  * *       '    '*    *        ");
            ConsoleHelper.Write("*     *  ' *    ''  **        **      ''             **            '*   *      * ''     ");
            ConsoleHelper.Write("* *                         ''             **          '         *              ''   *  ");
            ConsoleHelper.Write("*     *  ' *    ''  **                ''*  *         **      ''    '    *      *      * ");
            ConsoleHelper.Write("  ' *       ''              ''*  *         **     ''   '*   *       '    '***  *        ");
            ConsoleHelper.Write("      *  ' *    ''  **        **      ''*  *         **            '*** *      * ''     ");
            ConsoleHelper.Write("*    ' *    ''   ''   ***   ''* **         **          '**                 *    ''*     ");
            ConsoleHelper.Write("*     *  ' *    ''  **                ''  **         **      ''    '*** *         *   * ");
            ConsoleHelper.Write("     ' *    ''  **          ''**           **     ''   '*** *       '    '***     *     ");
            ConsoleHelper.Write("  *  ' *    ''  *                *  *'                     *        *         *    ''*  ");
            ConsoleHelper.Write(" *         *              *    **                    *                            *     ");
            ConsoleHelper.Write("      *          * *                       *                                *           ");
            Thread.Sleep(2000);
            ConsoleHelper.Clear();

            ConsoleHelper.Write("****************************************************************************************");
            ConsoleHelper.Write("                           Welcome to the Wonder Woods");
            ConsoleHelper.Write("****************************************************************************************");
            Thread.Sleep(2000);
            ConsoleHelper.Write("Your friend Kaj has been kidnapped by the evil Ice Queen...");
            ConsoleHelper.Write("****************************************************************************************");
            ConsoleHelper.Write("The Ice Queen is planning to take over your home, the Wonder Woods!");
            ConsoleHelper.Write("****************************************************************************************");
            ConsoleHelper.Write("You need to collect three keys and get to the Queen's Ice Palace to help him escape.");
            ConsoleHelper.Write("****************************************************************************************");
            ConsoleHelper.Write("Expore the Wonder Woods and interact with the characters you meet...");
            ConsoleHelper.Write("****************************************************************************************");
            Thread.Sleep(5000);
            ConsoleHelper.Write("Press any key to continue...");
            ConsoleHelper.ReadKey();

            ConsoleHelper.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            ConsoleHelper.Write("But first, tell me your name...");
            var UserName = ConsoleHelper.Read();
            ConsoleHelper.Write("Hello " + UserName + ", are you ready for an adventure?");
            UserHelper.CreateUser(UserName);
            ConsoleHelper.Write("Press any key to continue...");
            ConsoleHelper.ReadKey();
        }

        public static bool PlayAgain()
        {
            ConsoleHelper.Write("Would you like play again, it will reset your stats");
            ConsoleHelper.Write("Press Y if you would like to play again, else press any key to return");
            var answer = ConsoleHelper.ReadKey();
            return answer == 'y' || answer == 'Y';
        }

        public static void MainMenuMessage()
        {
            ConsoleHelper.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            ConsoleHelper.Write("****************************************************************************************");
            ConsoleHelper.Write("                                 Main Menu");
            ConsoleHelper.Write("****************************************************************************************");
            ConsoleHelper.Write("1) Go out and save your friend Kaj from the Ice Queen!");
            ConsoleHelper.Write("2) Show Stats");
            ConsoleHelper.Write("3) Show Rules of Game");
            ConsoleHelper.Write("4) Exit Game");
            ConsoleHelper.Write("****************************************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void RulesOfGame()
        {
            ConsoleHelper.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            ConsoleHelper.Write("****************************************************************************************");
            ConsoleHelper.Write("                               RULES OF THE GAME");
            ConsoleHelper.Write("****************************************************************************************");
            ConsoleHelper.Write("The game is divided into three levels. ");
            ConsoleHelper.Write("Each level will start with a Crossroad where you are asked to choose left or right.");
            ConsoleHelper.Write("If you chose to go the correct path through the Wonder Woods you will meet a character.");
            ConsoleHelper.Write("");
            ConsoleHelper.Write("The character will ask you a question that you must answer correctly to continue your journey.");
            ConsoleHelper.Write("The level will then continue with another Crossroad and so on, until you have correctly answered five questions.");
            ConsoleHelper.Write("You will collect a randomized amount of Diamonds during your quest and use them to buy yourself clues.");
            ConsoleHelper.Write("");
            ConsoleHelper.Write("When you have outwitted the fifth character on each level you will obtain one of the three keys.");
            ConsoleHelper.Write("The three keys you will use to set your friend Kaj free from the Evil Ice Queen.");
            ConsoleHelper.Write("If you are unable to correctly answer a question, you will be sent back one step in the game.");
            ConsoleHelper.Write("");
            ConsoleHelper.Write("GOOD LUCK!");
            Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.White;
            ConsoleHelper.Write("Press any key to continue...");
            ConsoleHelper.ReadKey();
        }

        public static void MenuErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            ConsoleHelper.Write("Enter a number between 1-4 to chose an alternative from the menu.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void QuestionErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            ConsoleHelper.Write("You answer the question by pressing A, B or C!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void YouWinMessage(User user)
        {
            while (true)
            {
                ConsoleHelper.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                ConsoleHelper.Write("Wohoo! You now have all the three keys to free your friend from the evil Ice Queen!!!");
                ConsoleHelper.Write("Congratulations, you now have won the game!");
                Thread.Sleep(3000);
                ConsoleHelper.Write("Press any key to go exit the game.");
                ConsoleHelper.ReadKey();
                return;
            }
        }
    }
}