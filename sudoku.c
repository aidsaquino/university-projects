/* This program is a simple sudoku game, which serves as a final requirement for the Course: Programming in C, which I took on my first year */

#include <stdio.h>

void printIntro();
main(){
int choice, choice2, aids[9][9], edt[9][9]= {0}, i, j, ans, check = 0;
char intro[500], template[500];
FILE *fp;

     fp = fopen("template 1.txt" , "r");
           for(i=0; i<9; i++){
               
                          fscanf(fp, "%d %d %d %d %d %d %d %d %d", &aids[i][0], &aids[i][1], &aids[i][2], &aids[i][3], &aids[i][4], &aids[i][5], &aids[i][6], &aids[i][7], &aids[i][8]);
           } fclose(fp);
 do{
    printf("\n------------------------------------------\n");
    printf("   _________    _     _     _____       _______     ___   ____   _      _\n  /  ______/   / \   / \   /  _  \     /  ___  \   /  /  /   /  / \    / \\n  \  \_____   /  /  /  /  /  / \  \   /  /  /  /  /  /__/   /  /  /   /  /\n   \___   /  /  /  /  /  /  /  /  /  /  /  /  /  /  __  ___/  /  /   /  /\n   ___/  /  /  /__/  /  /  /__/  /  /  /__/  /  /  /  \  \   /  /___/  /\n   \____/   \_______/  /________/   \_______/  /__/   /__/   \________/  \n\n");
    printf("\t\tSUDOKU\nAQUINO, ADRIAN A. | 2012-04619 | S-1L\n\n\n[1]instructions\n[2]start\n[3]exit\n\n");
    printf("\n------------------------------------------\n");
    scanf("%d", &choice);
    if(choice == 1){
              printIntro();
    } 
    else if(choice == 2){
         do{
         printf("Watcha gonna do?!\n\n[1]Enter Data\n[2]Check\n\n");
         scanf("%d", &choice2);
         if(choice2 == 1){
         printf("   0  1  2  3  4  5  6  7  8\n");
         printf("   -------------------------\n");
         printf("0| 3  2  %d  9  8  7  4  5  6\n\n", edt[0][2]);
         printf("1| 4  5  6  3  2  1  9  8  7\n\n");
         printf("2| 9  %d  7  4  5  6  3  2  1\n\n", edt[2][1]);
         printf("3| 1  3  %d  7  9  8  6  4  5\n\n", edt[3][2]);
         printf("4| 6  4  5  1  3  2  5  6  4\n\n");
         printf("5| 7  %d  8  6  4  5  1  3  2\n\n", edt[5][1]);
         printf("6| 2  1  3  8  7  9  %d  6  4\n\n", edt[6][6]);
         printf("7| 5  6  %d  2  1  3  8  7  9\n\n", edt[7][2]);
         printf("8| 8  7  9  5  6  4  2  1  3\n\n");
         printf("   -------------------------\n");
         
         
         printf("Enter the row you want to edit:");
         scanf("%d", &i);
         printf("Enter the column you want to edit:");
         scanf("%d", &j);
         printf("Enter the value:");
         scanf("%d", &ans);
         edt[i][j] = ans;
   
         
         
         printf("   0  1  2  3  4  5  6  7  8\n");
         printf("   -------------------------\n");
         printf("0| 3  2  %d  9  8  7  4  5  6\n\n", edt[0][2]);
         printf("1| 4  5  6  3  2  1  9  8  7\n\n");
         printf("2| 9  %d  7  4  5  6  3  2  1\n\n", edt[2][1]);
         printf("3| 1  3  %d  7  9  8  6  4  5\n\n", edt[3][2]);
         printf("4| 6  4  5  1  3  2  5  6  4\n\n");
         printf("5| 7  %d  8  6  4  5  1  3  2\n\n", edt[5][1]);
         printf("6| 2  1  3  8  7  9  %d  6  4\n\n", edt[6][6]);
         printf("7| 5  6  %d  2  1  3  8  7  9\n\n", edt[7][2]);
         printf("8| 8  7  9  5  6  4  2  1  3\n\n");
         printf("   -------------------------\n");
         
    }else if(choice2 == 2){
          if(edt[0][2]==aids[0][2]){
                                     printf("%d %d\n", edt[0][2], aids[0][2]);
                                     check++;
          }
          if(edt[2][1]==aids[2][1]){
                                      printf("%d %d\n", edt[2][1], aids[2][1]);
                                      check++;
          } if(edt[3][2]==aids[3][2]){
                                      printf("%d %d\n", edt[3][2], aids[3][2]);
                                      check++;
          } if(edt[5][1]==aids[5][1]){
                                      printf("%d %d\n", edt[5][1], aids[5][1]);
                                      check++;
          } if(edt[6][6]==aids[6][6]){
                                      printf("%d %d\n", edt[6][6], aids[6][6]);
                                      check++;
          } if(edt[7][2]==aids[7][2]){
                                      printf("%d %d\n", edt[7][2], aids[7][2]);
                                      check++;
          } if(check == 6){
                     printf("Pwede ka nang mag-asawa!! Congratulations!!!\n\n");
                     break;
                     } else{
                     printf("Sorry may mali ka. :((\n\n");
                            }
          }
          }while(choice2!=2);
} 
    }while(choice != 3);
    
    
    
}

void printIntro(){
     FILE *fp;
     char intro[500];
              fp = fopen("aids.txt", "r");
              getchar();
              while(!feof(fp)){
                               fscanf(fp, "%[^\t]", intro);
                               printf("%s", intro);
              } fclose(fp);
     }


