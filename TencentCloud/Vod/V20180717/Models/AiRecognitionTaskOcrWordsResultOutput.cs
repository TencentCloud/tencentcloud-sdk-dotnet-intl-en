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

    public class AiRecognitionTaskOcrWordsResultOutput : AbstractModel
    {
        
        /// <summary>
        /// Text keyword recognition result set
        /// <font color=red>Note</font>: this list displays up to the first 100 results. You can get all the results from the file whose URL is `SegmentSetFileUrl`.
        /// </summary>
        [JsonProperty("ResultSet")]
        public AiRecognitionTaskOcrWordsResultItem[] ResultSet{ get; set; }

        /// <summary>
        /// URL to the file of the text keyword recognition result set. The file format is JSON, and the data structure is the same as `SegmentSet`. The file will be deleted upon the expiration time `SegmentSetFileUrlExpireTime`, instead of being stored permanently.
        /// </summary>
        [JsonProperty("ResultSetFileUrl")]
        public string ResultSetFileUrl{ get; set; }

        /// <summary>
        /// Expiration time of the URL to the file of the text keyword recognition result set, in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732)
        /// </summary>
        [JsonProperty("ResultSetFileUrlExpireTime")]
        public string ResultSetFileUrlExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ResultSet.", this.ResultSet);
            this.SetParamSimple(map, prefix + "ResultSetFileUrl", this.ResultSetFileUrl);
            this.SetParamSimple(map, prefix + "ResultSetFileUrlExpireTime", this.ResultSetFileUrlExpireTime);
        }
    }
}

