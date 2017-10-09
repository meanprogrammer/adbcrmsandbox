using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMSandboxService
{
    public static class ObjectConverter
    {
        public static List<AccountProxy> ConvertToListOfAccount(IEnumerable<Account> accounts, SandboxCRMContext context)
        {
            List<AccountProxy> list = new List<AccountProxy>();

            foreach (Account a in accounts)
            {
                AccountProxy ap = ConvertToSingleAccount(a);
                list.Add(ap);
            }
            return list;
        }

        public static AccountProxy ConvertToSingleAccount(Account account)
        {
            AccountProxy proxyObj = new AccountProxy();

            proxyObj.AccountName = account.Name;
            proxyObj.AccountNumber = account.AccountNumber;
            proxyObj.Fax = account.Fax;
            proxyObj.Phone = "no phone";
            proxyObj.LegalEntityIdentifier = account.new_LEI;
            proxyObj.Website = account.WebSiteURL;

            return proxyObj;
        }
    }
}