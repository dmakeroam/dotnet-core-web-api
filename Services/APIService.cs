using Microsoft.Extensions.Options;
using DotNetCoreWebAPI.Models;

namespace DotNetCoreWebAPI.Services {
    public class APIService {

        private readonly DatabaseConfig _dbOptions;
        
        public APIService(IOptions<DatabaseConfig> dbOptions)
        {
            _dbOptions = dbOptions.Value;
        }

        public string ConnectionToDatabase(){
            return "Hello World with Hello World: "+_dbOptions.DBURL+", DB_USERNAME: "+_dbOptions.DBUserName+", DB_PASSWORD: "+_dbOptions.DBPassword;
        }
    }
}
