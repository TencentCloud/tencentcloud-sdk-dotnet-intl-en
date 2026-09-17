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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DomainDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AccelerateAreaInfos")]
        public AccelerateAreaInfo[] AccelerateAreaInfos{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DeployStatus")]
        public string DeployStatus{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("HTTPSConfig")]
        public DomainHTTPSConfig HTTPSConfig{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("UrlSignatureAuthPolicy")]
        public UrlSignatureAuthPolicy UrlSignatureAuthPolicy{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RefererAuthPolicy")]
        public RefererAuthPolicy RefererAuthPolicy{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("QUICConfig")]
        public DomainQUICConfig QUICConfig{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("IPFilterPolicy")]
        public IPFilterPolicy IPFilterPolicy{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArrayObj(map, prefix + "AccelerateAreaInfos.", this.AccelerateAreaInfos);
            this.SetParamSimple(map, prefix + "DeployStatus", this.DeployStatus);
            this.SetParamObj(map, prefix + "HTTPSConfig.", this.HTTPSConfig);
            this.SetParamObj(map, prefix + "UrlSignatureAuthPolicy.", this.UrlSignatureAuthPolicy);
            this.SetParamObj(map, prefix + "RefererAuthPolicy.", this.RefererAuthPolicy);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamObj(map, prefix + "QUICConfig.", this.QUICConfig);
            this.SetParamObj(map, prefix + "IPFilterPolicy.", this.IPFilterPolicy);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

