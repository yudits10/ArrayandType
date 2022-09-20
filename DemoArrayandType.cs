int main()
{
    int i = 10, j = 3;
    if (i < 5 || j > 0)
    {
        j++;
        i++;
    }
    printf("%d %d", i, j);
    return 0;
}