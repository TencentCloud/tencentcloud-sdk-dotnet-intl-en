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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BaseStateAction : AbstractModel
    {
        
        /// <summary>
        /// Whether the edit button is visible.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ShowEdit")]
        public bool? ShowEdit{ get; set; }

        /// <summary>
        /// Whether the edit button is clickable.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsEdit")]
        public bool? IsEdit{ get; set; }

        /// <summary>
        /// Edit button text.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EditText")]
        public string EditText{ get; set; }

        /// <summary>
        /// Edit-disabled hint.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EditTips")]
        public string EditTips{ get; set; }

        /// <summary>
        /// Whether the deletion button is visible.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ShowDel")]
        public bool? ShowDel{ get; set; }

        /// <summary>
        /// Whether the deletion button is clickable.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsDel")]
        public bool? IsDel{ get; set; }

        /// <summary>
        /// Delete button text.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DelText")]
        public string DelText{ get; set; }

        /// <summary>
        /// Delete-disabled hint.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DelTips")]
        public string DelTips{ get; set; }

        /// <summary>
        /// Whether the copy button is visible.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ShowCopy")]
        public bool? ShowCopy{ get; set; }

        /// <summary>
        /// Whether it is visible.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ShowView")]
        public bool? ShowView{ get; set; }

        /// <summary>
        /// Whether renaming is allowed.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ShowRename")]
        public bool? ShowRename{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ShowEdit", this.ShowEdit);
            this.SetParamSimple(map, prefix + "IsEdit", this.IsEdit);
            this.SetParamSimple(map, prefix + "EditText", this.EditText);
            this.SetParamSimple(map, prefix + "EditTips", this.EditTips);
            this.SetParamSimple(map, prefix + "ShowDel", this.ShowDel);
            this.SetParamSimple(map, prefix + "IsDel", this.IsDel);
            this.SetParamSimple(map, prefix + "DelText", this.DelText);
            this.SetParamSimple(map, prefix + "DelTips", this.DelTips);
            this.SetParamSimple(map, prefix + "ShowCopy", this.ShowCopy);
            this.SetParamSimple(map, prefix + "ShowView", this.ShowView);
            this.SetParamSimple(map, prefix + "ShowRename", this.ShowRename);
        }
    }
}

