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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SupportDownloadType : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("NGINX")]
        public bool? NGINX{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("APACHE")]
        public bool? APACHE{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TOMCAT")]
        public bool? TOMCAT{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("IIS")]
        public bool? IIS{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("JKS")]
        public bool? JKS{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OTHER")]
        public bool? OTHER{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ROOT")]
        public bool? ROOT{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NGINX", this.NGINX);
            this.SetParamSimple(map, prefix + "APACHE", this.APACHE);
            this.SetParamSimple(map, prefix + "TOMCAT", this.TOMCAT);
            this.SetParamSimple(map, prefix + "IIS", this.IIS);
            this.SetParamSimple(map, prefix + "JKS", this.JKS);
            this.SetParamSimple(map, prefix + "OTHER", this.OTHER);
            this.SetParamSimple(map, prefix + "ROOT", this.ROOT);
        }
    }
}

