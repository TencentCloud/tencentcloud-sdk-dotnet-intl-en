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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReleaseQA : AbstractModel
    {
        
        /// <summary>
        /// Question.
        /// </summary>
        [JsonProperty("Question")]
        public string Question{ get; set; }

        /// <summary>
        /// Update time.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Status.
        /// </summary>
        [JsonProperty("Action")]
        public ulong? Action{ get; set; }

        /// <summary>
        /// Status description.
        /// </summary>
        [JsonProperty("ActionDesc")]
        public string ActionDesc{ get; set; }

        /// <summary>
        /// Source, 1: documentation generation; 2: batch import; 3: manual addition.
        /// </summary>
        [JsonProperty("Source")]
        public ulong? Source{ get; set; }

        /// <summary>
        /// Source description.
        /// </summary>
        [JsonProperty("SourceDesc")]
        public string SourceDesc{ get; set; }

        /// <summary>
        /// Filename.
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// Document type.
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// Reason for failure
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// Release status.
        /// </summary>
        [JsonProperty("ReleaseStatus")]
        public ulong? ReleaseStatus{ get; set; }

        /// <summary>
        /// Q&A ID.
        /// </summary>
        [JsonProperty("QaBizId")]
        public string QaBizId{ get; set; }

        /// <summary>
        /// Document business ID.
        /// </summary>
        [JsonProperty("DocBizId")]
        public string DocBizId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Question", this.Question);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "ActionDesc", this.ActionDesc);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "SourceDesc", this.SourceDesc);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "ReleaseStatus", this.ReleaseStatus);
            this.SetParamSimple(map, prefix + "QaBizId", this.QaBizId);
            this.SetParamSimple(map, prefix + "DocBizId", this.DocBizId);
        }
    }
}

