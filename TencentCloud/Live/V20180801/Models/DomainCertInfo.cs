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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DomainCertInfo : AbstractModel
    {
        
        /// <summary>
        /// Certificate ID.
        /// </summary>
        [JsonProperty("CertId")]
        public long? CertId{ get; set; }

        /// <summary>
        /// Certificate name.
        /// </summary>
        [JsonProperty("CertName")]
        public string CertName{ get; set; }

        /// <summary>
        /// Description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Creation time in UTC format.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Certificate content.
        /// </summary>
        [JsonProperty("HttpsCrt")]
        public string HttpsCrt{ get; set; }

        /// <summary>
        /// Certificate type.
        /// 0: user-added certificate
        /// 1: Tencent Cloud-hosted certificate.
        /// </summary>
        [JsonProperty("CertType")]
        public long? CertType{ get; set; }

        /// <summary>
        /// Certificate expiration time in UTC format.
        /// </summary>
        [JsonProperty("CertExpireTime")]
        public string CertExpireTime{ get; set; }

        /// <summary>
        /// Domain name that uses this certificate.
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// Certificate status.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "CertName", this.CertName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "HttpsCrt", this.HttpsCrt);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
            this.SetParamSimple(map, prefix + "CertExpireTime", this.CertExpireTime);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

