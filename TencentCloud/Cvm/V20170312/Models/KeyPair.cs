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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KeyPair : AbstractModel
    {
        
        /// <summary>
        /// Key pair `ID`, the unique identifier of a key pair.
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// Key pair name.
        /// </summary>
        [JsonProperty("KeyName")]
        public string KeyName{ get; set; }

        /// <summary>
        /// `ID` of the project to which a key pair belongs.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Key pair description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Content of public key in a key pair.
        /// </summary>
        [JsonProperty("PublicKey")]
        public string PublicKey{ get; set; }

        /// <summary>
        /// Content of private key in a key pair. Tencent Cloud do not keep private keys. Please keep it properly.
        /// </summary>
        [JsonProperty("PrivateKey")]
        public string PrivateKey{ get; set; }

        /// <summary>
        /// `ID` list of instances associated with a key.
        /// </summary>
        [JsonProperty("AssociatedInstanceIds")]
        public string[] AssociatedInstanceIds{ get; set; }

        /// <summary>
        /// Creation time, which follows the `ISO8601` standard and uses `UTC` time in the format of `YYYY-MM-DDThh:mm:ssZ`.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "KeyName", this.KeyName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "PublicKey", this.PublicKey);
            this.SetParamSimple(map, prefix + "PrivateKey", this.PrivateKey);
            this.SetParamArraySimple(map, prefix + "AssociatedInstanceIds.", this.AssociatedInstanceIds);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
        }
    }
}

