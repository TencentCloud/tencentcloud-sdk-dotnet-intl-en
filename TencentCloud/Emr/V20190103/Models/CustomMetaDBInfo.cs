/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomMetaDBInfo : AbstractModel
    {
        
        /// <summary>
        /// The JDBC URL of the custom metadatabase instance. Example: jdbc:mysql://10.10.10.10:3306/dbname
        /// </summary>
        [JsonProperty("MetaDataJdbcUrl")]
        public string MetaDataJdbcUrl{ get; set; }

        /// <summary>
        /// The custom metadatabase instance username.
        /// </summary>
        [JsonProperty("MetaDataUser")]
        public string MetaDataUser{ get; set; }

        /// <summary>
        /// The custom metadatabase instance password.
        /// </summary>
        [JsonProperty("MetaDataPass")]
        public string MetaDataPass{ get; set; }

        /// <summary>
        /// The Hive-shared metadatabase type. Valid values:
        /// <li>`EMR_NEW_META`: The cluster creates a metadatabase by default.</li>
        /// <li>`EMR_EXIST_META`: The cluster uses a specified EMR-MetaDB instance.</li>
        /// <li>`USER_CUSTOM_META`: The cluster uses a custom metadatabase instance.</li>
        /// </summary>
        [JsonProperty("MetaType")]
        public string MetaType{ get; set; }

        /// <summary>
        /// The EMR-MetaDB instance.
        /// </summary>
        [JsonProperty("UnifyMetaInstanceId")]
        public string UnifyMetaInstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MetaDataJdbcUrl", this.MetaDataJdbcUrl);
            this.SetParamSimple(map, prefix + "MetaDataUser", this.MetaDataUser);
            this.SetParamSimple(map, prefix + "MetaDataPass", this.MetaDataPass);
            this.SetParamSimple(map, prefix + "MetaType", this.MetaType);
            this.SetParamSimple(map, prefix + "UnifyMetaInstanceId", this.UnifyMetaInstanceId);
        }
    }
}

