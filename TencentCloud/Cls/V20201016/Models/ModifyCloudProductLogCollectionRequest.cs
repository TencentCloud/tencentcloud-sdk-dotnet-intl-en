/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyCloudProductLogCollectionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Instance ID.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Cloud product identifier, supports enumerate: CDS, CWP, CDB, TDSQL-C, MongoDB, TDStore, DCDB, MariaDB, PostgreSQL, BH, APIS</p>
        /// </summary>
        [JsonProperty("AssumerName")]
        public string AssumerName{ get; set; }

        /// <summary>
        /// <p>Log type. Supports enumeration: CDS-AUDIT, CDS-RISK, CDB-AUDIT, TDSQL-C-AUDIT, MongoDB-AUDIT, MongoDB-SlowLog, MongoDB  ErrorLog, TDMYSQL-SLOW, DCDB-AUDIT, DCDB-SLOW, DCDB-ERROR, MariaDB-AUDIT, MariaDB-SLOW, MariaDB-ERROR, PostgreSQL-SLOW, PostgreSQL-ERROR, PostgreSQL-AUDIT, BH-FILELOG, BH-COMMANDLOG, APIS-ACCESS</p>
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// <p>Product region. Different log types have different region input formats. Refer to the following example:</p><ul><li>All CDS log types: ap-guangzhou</li><li>CDB-AUDIT: gz</li><li>TDSQL-C-AUDIT: gz</li><li>MongoDB-AUDIT: gz</li><li>MongoDB-SlowLog: ap-guangzhou</li><li>MongoDB-ErrorLog: ap-guangzhou</li><li>TDMYSQL-SLOW: gz</li><li>All DCDB log types: gz</li><li>All MariaDB log types: gz</li><li>All PostgreSQL log types: gz</li><li>All BH log types: overseas-polaris(Hong Kong (China) and other)/fsi-polaris(financial district)/general-polaris(general zone)/intl-sg-prod(international site)</li><li>All APIS log types: gz</li></ul>
        /// </summary>
        [JsonProperty("CloudProductRegion")]
        public string CloudProductRegion{ get; set; }

        /// <summary>
        /// <p>Logging configuration extended information, generally used to store additional log delivery configuration</p>
        /// </summary>
        [JsonProperty("Extend")]
        public string Extend{ get; set; }

        /// <summary>
        /// <p>Description list of tags. By specifying this parameter, you can simultaneously bind tags to the appropriate logset and topic. Supports a maximum of 10 tag key-value pairs. The same resource can only be bound to the same tag key.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AssumerName", this.AssumerName);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "CloudProductRegion", this.CloudProductRegion);
            this.SetParamSimple(map, prefix + "Extend", this.Extend);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

