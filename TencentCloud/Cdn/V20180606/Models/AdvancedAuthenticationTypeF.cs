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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AdvancedAuthenticationTypeF : AbstractModel
    {
        
        /// <summary>
        /// Signature field name in the URI string, starting with a letter, and consisting of letters, digits, and underscores.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SignParam")]
        public string SignParam{ get; set; }

        /// <summary>
        /// Time field name in the URI string, starting with a letter, and consisting of letters, digits, and underscores.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TimeParam")]
        public string TimeParam{ get; set; }

        /// <summary>
        /// Transaction field name in the URI string, starting with a letter, and consisting of letters, digits, and underscores.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TransactionParam")]
        public string TransactionParam{ get; set; }

        /// <summary>
        /// CMK used for signature calculation, allowing 6 to 32 bytes of letters and digits.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// Alternative key used for signature calculation, which is used after the CMK fails in authentication. It allows 6 to 32 bytes of letters and digits.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BackupSecretKey")]
        public string BackupSecretKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SignParam", this.SignParam);
            this.SetParamSimple(map, prefix + "TimeParam", this.TimeParam);
            this.SetParamSimple(map, prefix + "TransactionParam", this.TransactionParam);
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
            this.SetParamSimple(map, prefix + "BackupSecretKey", this.BackupSecretKey);
        }
    }
}

