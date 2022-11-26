import java.util.Scanner;

public class Gifts {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());;

        StringBuilder boxes = new StringBuilder();
        for (int i = 0; i < 2*n; i++) {
            if (i < n) {
                boxes.append('0');
            } else {
                boxes.append('1');
            }
        }

        int size = 2 * n;
        int wantedNum = 1;
        while (true) {
            int counter = 0;
            int pos = 0;
            StringBuilder temp = boxes;
            while (true) {
                pos += wantedNum - 1;
                if (pos > size - counter - 1) {
                    pos %= (size - counter);
                }

                if (temp.charAt(pos) == '0') {
                    break;
                } else {
                    temp.delete(pos, pos);
                    counter++;
                }
            }
            if (counter == n) {
                break;
            }

            wantedNum++;
        }
        System.out.println(wantedNum);
    }
}
