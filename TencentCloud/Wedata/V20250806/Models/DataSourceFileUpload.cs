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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataSourceFileUpload : AbstractModel
    {
        
        /// <summary>
        /// Truststore authentication file, default filename truststore.jks.
        /// </summary>
        [JsonProperty("TrustStore")]
        public string TrustStore{ get; set; }

        /// <summary>
        /// Keystore authentication file, default filename keystore.jks.
        /// </summary>
        [JsonProperty("KeyStore")]
        public string KeyStore{ get; set; }

        /// <summary>
        /// core-site.xml file.
        /// </summary>
        [JsonProperty("CoreSite")]
        public string CoreSite{ get; set; }

        /// <summary>
        /// hdfs-site.xml file.
        /// </summary>
        [JsonProperty("HdfsSite")]
        public string HdfsSite{ get; set; }

        /// <summary>
        /// hive-site.xml file.
        /// </summary>
        [JsonProperty("HiveSite")]
        public string HiveSite{ get; set; }

        /// <summary>
        /// hbase-site file.
        /// </summary>
        [JsonProperty("HBASESite")]
        public string HBASESite{ get; set; }

        /// <summary>
        /// Keytab file, default filename [data source name].keytab.
        /// </summary>
        [JsonProperty("KeyTab")]
        public string KeyTab{ get; set; }

        /// <summary>
        /// krb5.conf file.
        /// </summary>
        [JsonProperty("KRB5Conf")]
        public string KRB5Conf{ get; set; }

        /// <summary>
        /// Private key, default filename private_key.pem.
        /// </summary>
        [JsonProperty("PrivateKey")]
        public string PrivateKey{ get; set; }

        /// <summary>
        /// Public key, default filename public_key.pem.
        /// </summary>
        [JsonProperty("PublicKey")]
        public string PublicKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TrustStore", this.TrustStore);
            this.SetParamSimple(map, prefix + "KeyStore", this.KeyStore);
            this.SetParamSimple(map, prefix + "CoreSite", this.CoreSite);
            this.SetParamSimple(map, prefix + "HdfsSite", this.HdfsSite);
            this.SetParamSimple(map, prefix + "HiveSite", this.HiveSite);
            this.SetParamSimple(map, prefix + "HBASESite", this.HBASESite);
            this.SetParamSimple(map, prefix + "KeyTab", this.KeyTab);
            this.SetParamSimple(map, prefix + "KRB5Conf", this.KRB5Conf);
            this.SetParamSimple(map, prefix + "PrivateKey", this.PrivateKey);
            this.SetParamSimple(map, prefix + "PublicKey", this.PublicKey);
        }
    }
}

