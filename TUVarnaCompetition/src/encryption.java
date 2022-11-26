import java.util.Scanner;

public class encryption {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String word = scanner.nextLine();
        int number = Integer.parseInt(scanner.nextLine());

        StringBuilder sb = new StringBuilder(word);
        String substring = sb.substring(sb.length() - number, sb.length());
        sb.insert(0, substring);
        sb.delete(sb.length() - number, sb.length());

        StringBuilder result = new StringBuilder();
        for (int i = 0; i < sb.length(); i++) {
            int currCharASCII = sb.charAt(i);
            int newCharASCII = currCharASCII + number;
            char newChar = (char) newCharASCII;
            result.append(newChar);
        }
        System.out.println(result);
    }
}
