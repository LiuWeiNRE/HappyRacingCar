/*
 * 编辑器工具类 —— 辅助自定义字体录入参数
 */

using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

public class CreateFontEditor : Editor
{
    [MenuItem("MyTools/CreateBMFont")]
    static void CreateFont()
    {
        // 当前选择的物体
        Object _obj = Selection.activeObject;
        //返回当前你选择的资源的路径
        string _fntPath = AssetDatabase.GetAssetPath(_obj);
        // 程序需要从fnt文件里面导入我们字模信息;
        if (_fntPath.IndexOf(".fnt") == -1)
        {
            Debug.Log("错误");
            return;
        }

        /*所有相关文件名字需要保持一致*/
        string _customFontPath = _fntPath.Replace(".fnt", ".fontsettings");
        if (!File.Exists(_customFontPath))
        {
            Debug.LogError("文件不存在：" + _customFontPath);
            return;
        }

        StreamReader _reader = new StreamReader(new FileStream(_fntPath, FileMode.Open));
        List<CharacterInfo> _charList = new List<CharacterInfo>();//字符信息列表
        //正则表达式
        Regex _reg = new Regex(@"char id=(?<id>\d+)\s+x=(?<x>\d+)\s+y=(?<y>\d+)\s+width=(?<width>\d+)\s+height=(?<height>\d+)\s+xoffset=(?<xoffset>\d+)\s+yoffset=(?<yoffset>\d+)\s+xadvance=(?<xadvance>\d+)\s+");
        string _line = _reader.ReadLine();
        int _lineHeight = 0;
        int _texWidth = 1;
        int _texHeight = 1;

        while (_line != null)
        {
            if (_line.IndexOf("char id=") != -1)
            {
                Match match = _reg.Match(_line);
                if (match != Match.Empty)
                {
                    var id = System.Convert.ToInt32(match.Groups["id"].Value);
                    var x = System.Convert.ToInt32(match.Groups["x"].Value);
                    var y = System.Convert.ToInt32(match.Groups["y"].Value);
                    var width = System.Convert.ToInt32(match.Groups["width"].Value);
                    var height = System.Convert.ToInt32(match.Groups["height"].Value);
                    var xoffset = System.Convert.ToInt32(match.Groups["xoffset"].Value);
                    var yoffset = System.Convert.ToInt32(match.Groups["yoffset"].Value);
                    var xadvance = System.Convert.ToInt32(match.Groups["xadvance"].Value);

                    CharacterInfo info = new CharacterInfo();
                    info.index = id;
                    float uvx = 1f * x / _texWidth;
                    float uvy = 1 - (1f * y / _texHeight);
                    float uvw = 1f * width / _texWidth;
                    float uvh = -1f * height / _texHeight;

                    info.uvBottomLeft = new Vector2(uvx, uvy);
                    info.uvBottomRight = new Vector2(uvx + uvw, uvy);
                    info.uvTopLeft = new Vector2(uvx, uvy + uvh);
                    info.uvTopRight = new Vector2(uvx + uvw, uvy + uvh);

                    info.minX = xoffset;
                    info.minY = yoffset + height / 2;   // 这样调出来的效果是ok的，原理未知  
                    info.glyphWidth = width;
                    info.glyphHeight = -height; // 同上，不知道为什么要用负的，可能跟unity纹理uv有关  
                    info.advance = xadvance;

                    _charList.Add(info);
                }
            }
            else if (_line.IndexOf("scaleW=") != -1)
            {
                Regex reg2 = new Regex(@"common lineHeight=(?<lineHeight>\d+)\s+.*scaleW=(?<scaleW>\d+)\s+scaleH=(?<scaleH>\d+)");
                Match match = reg2.Match(_line);
                if (match != Match.Empty)
                {
                    _lineHeight = System.Convert.ToInt32(match.Groups["lineHeight"].Value);
                    _texWidth = System.Convert.ToInt32(match.Groups["scaleW"].Value);
                    _texHeight = System.Convert.ToInt32(match.Groups["scaleH"].Value);
                }
            }
            _line = _reader.ReadLine();
        }

        Font customFont = AssetDatabase.LoadAssetAtPath<Font>(_customFontPath);
        customFont.characterInfo = _charList.ToArray();
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        Debug.Log("完成");
    }
}