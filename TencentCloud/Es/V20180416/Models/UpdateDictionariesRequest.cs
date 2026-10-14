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

    public class UpdateDictionariesRequest : AbstractModel
    {
        
        /// <summary>
        /// ES instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Address of the COS main dictionary for IK word segmentation entered during installation, and the dictionary name such as test.dic entered during deletion.
        /// </summary>
        [JsonProperty("IkMainDicts")]
        public string[] IkMainDicts{ get; set; }

        /// <summary>
        /// Address of the COS stopword dictionary for IK word segmentation during installation. When deleting, enter the dictionary name, for example, test.dic.
        /// </summary>
        [JsonProperty("IkStopwords")]
        public string[] IkStopwords{ get; set; }

        /// <summary>
        /// Address of the synonym dictionary COS during installation, and the dictionary name such as test.dic when deleting.
        /// </summary>
        [JsonProperty("Synonym")]
        public string[] Synonym{ get; set; }

        /// <summary>
        /// Address of the COS QQ tokenizer dictionary during installation, and the dictionary name such as test.dic during deletion.
        /// </summary>
        [JsonProperty("QQDict")]
        public string[] QQDict{ get; set; }

        /// <summary>
        /// 0: installation; 1: deletion. Default value: 0
        /// </summary>
        [JsonProperty("UpdateType")]
        public long? UpdateType{ get; set; }

        /// <summary>
        /// Whether to force restart the cluster. Default value: false
        /// </summary>
        [JsonProperty("ForceRestart")]
        public bool? ForceRestart{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "IkMainDicts.", this.IkMainDicts);
            this.SetParamArraySimple(map, prefix + "IkStopwords.", this.IkStopwords);
            this.SetParamArraySimple(map, prefix + "Synonym.", this.Synonym);
            this.SetParamArraySimple(map, prefix + "QQDict.", this.QQDict);
            this.SetParamSimple(map, prefix + "UpdateType", this.UpdateType);
            this.SetParamSimple(map, prefix + "ForceRestart", this.ForceRestart);
        }
    }
}

