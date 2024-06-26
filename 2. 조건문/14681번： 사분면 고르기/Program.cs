/* ************************************************************************** */
/*                                                                            */
/*                                                      :::    :::    :::     */
/*   Problem Number: 14681                             :+:    :+:      :+:    */
/*                                                    +:+    +:+        +:+   */
/*   By: lelelzhong <boj.kr/u/lelelzhong>            +#+    +#+          +#+  */
/*                                                  +#+      +#+        +#+   */
/*   https://boj.kr/14681                          #+#        #+#      #+#    */
/*   Solved: 2024/06/26 18:40:21 by lelelzhong    ###          ###   ##.kr    */
/*                                                                            */
/* ************************************************************************** */
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

if (x > 0)
{
    if (y > 0)
        Console.WriteLine(1);
    else if (y < 0)
        Console.WriteLine(4);
}
else if (x < 0)
{
    if (y > 0)
        Console.WriteLine(2);
    else if (y < 0)
        Console.WriteLine(3);
}