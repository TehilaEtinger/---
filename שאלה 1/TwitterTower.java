import java.util.Scanner;

public class TwitterTower {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int choice = 0;
        int width;
        int height;
        String option = "Choose an option:\n1. Build a rectangular tower\n2. Build a triangular tower\n3. Exit";
        while (true) {
            System.out.println(option);
            choice = scanner.nextInt();

            if (choice == 3) {
                System.out.println("Exiting program...");
                break;
            }
            else if (choice != 1 && choice != 2) {
                System.out.println("Invalid option. Please choose 1, 2, or 3.");
                continue;
            }
            System.out.println("Enter height:");
            height = scanner.nextInt();

            System.out.println("Enter width:");
            width = scanner.nextInt();

            Towers tower = new Towers(height, width);
            if (choice == 1)
                tower.rectangular();
            else if(choice == 2)
                tower.triangular();
        }
    }
}