namespace CarBook.WebApi.ViewModels
{
    public static class TokenBlackList
    {
        public static HashSet<string> BlacklistedTokens { get; set; } = new HashSet<string>();

    }
}
