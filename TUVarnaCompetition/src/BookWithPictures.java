import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class BookWithPictures {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int numberOfPages = Integer.parseInt(scanner.nextLine());
        int c = Integer.parseInt(scanner.nextLine());
        int[] pagesInPlace = Arrays.stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        List<Integer> pagesWithC = new ArrayList<>();
        for (int i = 1; i <= numberOfPages; i++) {
            boolean hasC = false;
            int currNum = i;
            while(currNum > 0) {
                int currDigit = currNum % 10;
                if(currDigit == c) {
                    hasC = true;
                    break;
                }
                currNum /= 10;
            }
            if(hasC) {
                pagesWithC.add(i);
            }
        }

        for (int i = 0; i < pagesWithC.size(); i++) {
            int currPage = pagesWithC.get(i);
            for (int j = 0; j < pagesInPlace.length; j++) {
                if(currPage == pagesInPlace[j]) {
                    pagesWithC.remove(i);
                    i--;
                    break;
                }
            }
        }

        List<Integer> anotherPages = new ArrayList<>();
        for (int i = 0; i < pagesWithC.size(); i++) {
            if(pagesWithC.get(i) % 2 == 0) {
                int anotherPage = pagesWithC.get(i) - 1;
                anotherPages.add(anotherPage);
            } else if(pagesWithC.get(i) != numberOfPages){
                int anotherPage = pagesWithC.get(i) + 1;
                anotherPages.add(anotherPage);
            }
        }

        for (int i = 0; i < anotherPages.size(); i++) {
            int currPage = anotherPages.get(i);
            for (int j = 0; j < pagesWithC.size(); j++) {
                if(currPage == pagesWithC.get(j)) {
                    anotherPages.remove(i);
                    i--;
                    break;
                }
            }
        }

        System.out.println(pagesWithC.size() + anotherPages.size());
    }
}
