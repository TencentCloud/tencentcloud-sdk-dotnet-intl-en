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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EsDictionaryInfo : AbstractModel
    {
        
        /// <summary>
        /// List of non-stop words
        /// </summary>
        [JsonProperty("MainDict")]
        public DictInfo[] MainDict{ get; set; }

        /// <summary>
        /// List of stop words
        /// </summary>
        [JsonProperty("Stopwords")]
        public DictInfo[] Stopwords{ get; set; }

        /// <summary>
        /// QQ dictionary list
        /// </summary>
        [JsonProperty("QQDict")]
        public DictInfo[] QQDict{ get; set; }

        /// <summary>
        /// Synonym dictionary list
        /// </summary>
        [JsonProperty("Synonym")]
        public DictInfo[] Synonym{ get; set; }

        /// <summary>
        /// Update dictionary type
        /// </summary>
        [JsonProperty("UpdateType")]
        public string UpdateType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "MainDict.", this.MainDict);
            this.SetParamArrayObj(map, prefix + "Stopwords.", this.Stopwords);
            this.SetParamArrayObj(map, prefix + "QQDict.", this.QQDict);
            this.SetParamArrayObj(map, prefix + "Synonym.", this.Synonym);
            this.SetParamSimple(map, prefix + "UpdateType", this.UpdateType);
        }
    }
}

