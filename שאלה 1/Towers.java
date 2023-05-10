import java.util.Scanner;
import java.lang.String;
//This class represents a tower and has the functions for handling towers
public class Towers {

    //variables
    private int height;
    private int width;

    //constructor
    public Towers(int height, int width) {
        this.height = height;
        this.width = width;
    }

    /*functions:
    This function is called when it is a rectangular tower,
    and it handles everything related to a rectangular tower*/
    public void rectangular() {
        if (Math.abs(height - width) > 5) {//Calculation of the area
            int area = height * width;
            System.out.println("The area of the tower is: " + area);
        }
        else//Calculation of the  perimeter
        {
            int perimeter = 2 * (height + width);
            System.out.println("The perimeter of the rectangular tower is: " + perimeter);
        }
    }

    /*This function is called when it is a triangular tower,
    and it handles everything related to a triangular tower*/
    public void triangular() {
        Scanner input = new Scanner(System.in);
        System.out.println("Choose an option:\n1. Calculate perimeter\n2. Print tower");
        int choice = input.nextInt();
        if (choice == 1) {////Calculation of the area
            double perimeter = Math.sqrt(Math.pow(width/2, 2) + Math.pow(height, 2));
            System.out.println("The perimeter of the rectangular tower is: " + perimeter);
        }
        else if (choice == 2) {
            printTriangle();
        } else {
            System.out.println("Invalid option.");
        }

    }


    //This function prints the triangular tower with asterisks
    private void printTriangle(){
        // Check if tower can be printed
        if (width % 2 == 0 || width >= 2 * height) {
            System.out.println("The triangle cannot be printed.");
        } else {
           // Calculate the number of asterisk in rows
           int numOfAsterisks = (width-2)/2;
           int numOfRows = (height-2)/ numOfAsterisks;
           int rest =  (height-2)-(numOfRows * numOfAsterisks);
           // Print top row
           int n = 3;
           String spaces = "";
           String string = "*";
           for (int i=0; i<=(width/2)-1; i++)
               spaces+=" ";
           System.out.println(spaces+"*");
            // Print remaining rows
           spaces = spaces.substring(0, spaces.length()-1);
           while(rest>0)
           {
               System.out.println(spaces+"***");
               rest--;
           }

           for (int i = 0; i< numOfAsterisks; i++){
               for(int j = 0; j< numOfRows; j++){
                   String repeated = new String(new char[n]).replace("\0", "*");
                   System.out.println(spaces+repeated);

               }
               n+=2;
               spaces = spaces.substring(0, spaces.length()-1);
           }
            // Print bottom row
            System.out.println(new String(new char[width]).replace("\0", "*"));
        }
    }

}
