// https://petlja.org/kurs/11171/33/2763
// https://petlja.org/biblioteka/r/Zbirka/histogram
// https://petlja.org/biblioteka/r/problemi/Zbirka/histogram
// https://petlja.org/biblioteka/r/problemi/Zbirka-stara/histogram
// https://arena.petlja.org/competition/r1-07-nizovi-05-preslikavanja#tab_132994
// https://arena.petlja.org/competition/r1-07-nizovi-04-vektori-polinomi#tab_132710
// https://arena.petlja.org/competition/skola-od-kuce-nizovi1-zadaci#tab_97594

Uses SysUtils;
Var
  n, k, i, h, podeok, brojZvezdica: Integer;
  a, b, d, x, procenat: Double;
  histogram: Array of Integer;

BEGIN
  ReadLn(a, b);
  ReadLn(n);
  d := (b - a) / n;
  SetLength(histogram, n);
  ReadLn(k);
  for i := 0 to k - 1 do
    begin
        ReadLn(x);
        podeok := Trunc((x - a) / d);
        histogram[podeok] := histogram[podeok] + 1;
    end;
  x := a;
  for h in histogram do
    begin
        WriteLn(Format('[%.3f, %.3f): ', [x, x + d]));
        WriteLn(h, #9);
        procenat := h / k;
        brojZvezdica := Round(100 * procenat);
        for i := 0 to brojZvezdica - 1 do Write('*');
        WriteLn;
        x := x + d;
    end;
END.