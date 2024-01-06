package Programs;

import java.util.Scanner;

public class Test2 
{
    public static void main(String[] args) {
        int[] marks = new int[15];
        int sum = 0;
        float avg = 0.0f;
        int temp = 0;
        int i = 0;
        int j = 0;
        int numEntries = 10;

        Scanner scanner = new Scanner(System.in);

        System.out.println("Enter ten marks:");

        for (i = 0; i < 10; i++) {
            marks[i] = scanner.nextInt();
        }

        System.out.println("-------------------------");
        // Calculate the sum of marks
        for (i = 0; i < 10; i++) {
            sum += marks[i];
        }
        System.out.println("Total marks: " + sum);
        System.out.println("-------------------------");
        // Calculate the average of marks
        avg = (sum / numEntries);
        System.out.println("Average mark: " + avg);
        System.out.println("-------------------------");
        // Sort the marks in ascending order
        for (i = 0; i < 10; i++) {
            for (j = i + 1; j < 10; j++) {
                if (marks[i] > marks[j]) {
                    temp = marks[i];
                    marks[i] = marks[j];
                    marks[j] = temp;
                }
            }
        }
        System.out.println("Marks in ascending order:");
        System.out.println("-------------------------");
        for (i = 0; i < 10; i++) {
            System.out.println(marks[i]);
        }
        System.out.println("-------------------------");
        System.out.println("Minimum mark: " + marks[0]);
        System.out.println("-------------------------");
        // Sort the marks in descending order
        for (i = 0; i < 10; i++) {
            for (j = i + 1; j < 10; j++) {
                if (marks[i] < marks[j]) {
                    temp = marks[i];
                    marks[i] = marks[j];
                    marks[j] = temp;
                }
            }
        }
    }
}