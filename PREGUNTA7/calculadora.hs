
getnum::IO Int
getnum = do
  s <- getLine
  return (read s)

main = do
  putStr("1.- Sumar\n2.- Restar\n3.- Multiplicar\n4.- Dividir\n>\n")
  opc <- getnum
  putStr("Numero 1:\n")
  numerou <- getnum
  putStr("Numero 2:\n")
  numerod <- getnum
  let suma=[c+d | c <- [numerou], d <- [numerod]]
  let resta=[c-d | c <- [numerou], d <- [numerod]]
  let multiplica=[c*d | c <- [numerou], d <- [numerod]]
  let divide=[c `div` d | c <- [numerou], d <- [numerod]]
  let resultado=if opc==1 then suma else if opc==2 then resta else if opc==3 then multiplica else if opc==4 then divide else []
  putStr("Resultado:"++show(resultado)++"\n")
  main