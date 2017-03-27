import java.lang.IllegalArgumentException;
import java.util.Map;
import java.util.HashMap;

public class DNA {
    private String dna;
    public DNA()
    {
        
    }
    public DNA(String dna)
    {
        this.dna = dna;
    }
    public Map<Character, Integer> nucleotideCounts()
    {//('ACGT', 0)
        Map<Character, Integer> m = new HashMap();
        m.put('A', count('A'));
        m.put('C', count('C'));
        m.put('G', count('G'));
        m.put('T', count('T'));
        return m;
    }
    public int count(char nucleotide)
    {
        if (!(nucleotide == 'A' || nucleotide == 'C' || nucleotide == 'G' || nucleotide == 'T')) {
            throw new IllegalArgumentException();
        }
        
        int nucCount = 0;
        for (int i = 0; i < dna.length(); i++) {
            if (dna.charAt(i) == nucleotide) {
                nucCount++;
            }
        }
        return nucCount;
    }
}
