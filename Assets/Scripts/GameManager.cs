using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("正解数の設定")]
    public int totalTargets = 3; // 目標となる配置数（正解の個数）

    private int currentCorrect = 0;
    private bool isCleared = false;

    // 正解を報告（1つ成功）
    public void ReportCorrect()
    {
        if (isCleared) return;

        currentCorrect++;
        Debug.Log($"正解数: {currentCorrect}/{totalTargets}");

        if (currentCorrect >= totalTargets)
        {
            OnClear();
        }
    }

    // 正解が解除されたとき
    public void ReportCancel()
    {
        if (isCleared) return;

        currentCorrect--;
        if (currentCorrect < 0) currentCorrect = 0;
        Debug.Log($"キャンセル: {currentCorrect}/{totalTargets}");
    }

    // すべて正解したときの処理
    void OnClear()
    {
        isCleared = true;
        Debug.Log("🎉 すべてのアイテムが正しく配置されました！");

        // ▼ ここにクリア演出（ドアを開ける、SE再生、UI表示など）を書く
        // 例：
        // doorAnimator.SetTrigger("Open");
        // victorySE.Play();
    }
}
