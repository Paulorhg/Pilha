using System;

public class Pilha
{
    private object[] elementos;
    private int topo, max;

    public Pilha(int maximo)
    {
        max = maximo;
        elementos = new object[max];
        topo = 0;
    }

    public void Push(object x) {
        if (PilhaCheia())
            throw new Exception("Pilha Cheia!");

        elementos[topo++] = x;
    }

    public object Pop() {
        if (PilhaVazia())
            throw new Exception("Pilha Vazia!");

        return elementos[--topo];
    }

    public bool PilhaCheia()
    {
        return topo == max;
    }

    public bool PilhaVazia()
    {
        return topo == 0;
    }

}
